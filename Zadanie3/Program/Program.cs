using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var dc = new BazaDanychDataContext();
            Tools.DataContext = dc;
            MyTools.DataContext = dc;

            //// przygotowanie listy MyProduct
            //List<MyProduct> myProducts = new List<MyProduct>();

            //var allProducts = dc.Product.ToList();

            //foreach (var product in allProducts)
            //{
            //    myProducts.Add(new MyProduct(product));
            //}

            //var myProductsByName = MyTools.GetProductsByVendorName(myProducts, "Australia Bike Retailer");
            //foreach (var myProduct in myProductsByName)
            //{
            //    Console.WriteLine(myProduct.Name);
            //}



            //var lista2 = Tools.GetProductsByVendorName("bicycles");
            //foreach (var itProduct in lista2)
            //{
            //    Console.WriteLine(itProduct.Name);
            //}
            //Console.WriteLine("-----------------------------------------------");

            ////try
            ////{
            ////    var podzielonaLista = lista2.PodzielNaStrony(5, 6);
            ////    foreach (var itProduct in podzielonaLista)
            ////    {
            ////        Console.WriteLine(itProduct.Name);
            ////    }
            ////}
            ////catch (Exception e)
            ////{
            ////    Console.WriteLine(e);
            ////}


            //var categories = dc.ProductCategory.Where(c => c.Name.Equals("Bikes")).ToList();

            //var lista3 = Tools.GetTotalStandardCostByCategory(categories[0]);
            ////Console.WriteLine(lista3);
            ////foreach (var itProduct in lista)
            ////{
            ////    Console.WriteLine(itProduct.Name);
            ////}

            //var vendorsForGivenProductName = Tools.GetProductVendorByProductName("Crankarm");
            ////Console.WriteLine(vendorsForGivenProductName);

            //Console.ReadKey();

            var lista = Tools.GetProductByName("Headset");

            Console.WriteLine(lista.GetProductAndVendorString());

        }
    }
}
