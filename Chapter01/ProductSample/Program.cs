using SampleApp;
using System;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123, "かりんとう", 180);
            Product daihuku = new Product(235, "大福もち", 160);
            Product dorayaki = new Product(98, "どら焼き", 210);

            int price = karinto.Price;   //税抜きの金額
            int taxIncluded = karinto.GetPriceIncludingTax();   //税込みの金額

            int daihukuPrice = daihuku.Price;
            int daihukuTaxincluded = daihuku.GetPriceIncludingTax();

            int dorayakiTax = dorayaki.GetTax();
            

            Console.WriteLine(karinto.Name + "の税込み金額" + taxIncluded + "円【税抜き" + price + "円】");

            Console.WriteLine(daihuku.Name + "の税込み金額" + daihukuTaxincluded + "円【税抜き" + daihukuPrice + "円】");

            Console.WriteLine($"{dorayakiTax}円");



        }
    }
}
