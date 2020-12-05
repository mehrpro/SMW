using System;
using System.ComponentModel.DataAnnotations;
using ShopManager.Models;

namespace ShopManager.ViewModels.Goods
{
    public class InvoiceTempList 
    {
        public DateTime InvoiceDate { get; set; }

        public byte InvoiceType_FK { get; set; }

        public int ProductList_FK { get; set; }

        public int Saller_FK { get; set; }

        public double PurchasePrice { get; set; }

        public int Unit_FK { get; set; }

        public double Numbers { get; set; }

        public byte Percent { get; set; }


        public string InvoiceNumber { get; set; }
        public double  Frosh { get; set; }
        public int AppUser_FK { get; set; }
        public string Goods { get; set; }
        public string UnitName { get; set; }
        public double Currency { get; set; }
        public double SumCurrency { get; set; }
    }
}