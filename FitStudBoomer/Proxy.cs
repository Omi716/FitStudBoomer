using FitStudBoomer.Domain;
using System;
using System.IO;

namespace FitStudBoomer
{
   public class Proxy 
    {
        private IMembership _membership;

        public Proxy(IMembership membership)
        {
            _membership = membership;
        }

        public static string GetPrice()
        {
            var price = GetPrice();

            Directory.CreateDirectory("logs");
            using(StreamWriter writer = new StreamWriter("logs/log.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " выдано абонементов " + price);
            }
            return price;
        }
    }
}
