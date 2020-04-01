using System;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Models
{
    public class SalerRecord
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public double Amount { get; set; }
        public SalerStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalerRecord()
        {

        }

        public SalerRecord(int id, DateTime date, double amount, SalerStatus status, Seller seller)
        {
            Id = id;
            this.date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
