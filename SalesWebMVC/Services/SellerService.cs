using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _Context;

        public SellerService(SalesWebMVCContext context)
        {
            _Context = context;
        }

        public List<Seller> FindAll()
        {
            return _Context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            //obj.Departament = _Context.Departament.First();
            _Context.Add(obj);
            _Context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _Context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _Context.Seller.Find(id);
            _Context.Seller.Remove(obj);
            _Context.SaveChanges();
        }
    }
}
