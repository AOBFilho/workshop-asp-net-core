using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc2.Models;
using SalesWebMvc2.Services.Exceptions;

namespace SalesWebMvc2.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc2Context _context;

        public SellerService(SalesWebMvc2Context context){
            _context = context;
        }
        
        public async Task<List<Seller>> FindAllAsync(){
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj){
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try{
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException) {
                throw new IntegrityException("Can't delete seller because he/she has sales");
            }
        }

        public async Task UpdateAsync(Seller obj){
            if (! await _context.Seller.AnyAsync(x => x.Id == obj.Id)){
                throw new NotFoundException("Id not found");
            }

            try {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException e) {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}