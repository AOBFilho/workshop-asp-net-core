using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }
        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }
        public void AddSeller(Seller seller){
            this.Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final){
            return this.Sellers.Sum(sl => sl.TotalSales(initial,final));
        }
    }
}