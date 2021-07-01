using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class ProductCache
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static decimal Precioc { get; set; }
        public static decimal Preciov { get; set; }
        public static int Unidades { get; set; }
        public static int Maxunides { get; set; }
        public static int Minunidades { get; set; }
        public static string Barcode { get; set; }
        public static string Family { get; set; }


    }
    public static class SellsDetail{
        public static int LastIdSell { get; set; }
    }
    public static class BuyDetails
    {
        public static int LastBuyId { get; set; }
    }



}
