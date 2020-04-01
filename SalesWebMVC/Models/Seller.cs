using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalerRecord> Sales { get; set; } = new List<SalerRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalerRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalerRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial,DateTime final)
        {
            return Sales.Where(sr => sr.date >= initial && sr.date <= final).Sum(sr => sr.Amount);
        }
    }
}
