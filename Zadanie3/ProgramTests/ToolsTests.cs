using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;

namespace ProgramTests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Tools.DataContext = new BazaDanychDataContext();
        }
        [TestMethod()]
        public void GetProductByNameTest()
        {
            /* sprawdzamy czy kwerenda
            select p.Name from Production.Product p where p.Name like '%Chain%' 
            i testowana funkcja zwracają identyczne wartości dla string-a "Chain" */
            var products = Tools.GetProductByName("Chain");
            List<string> productNames = products.Select(n => n.Name).ToList();
            List<string> toTestList = new List<string>()
            {
                "Chain", "Chain Stays", "Chainring", "Chainring Bolts", "Chainring Nut"
            };

            Assert.AreEqual(products.Count, toTestList.Count);
            foreach (var it in productNames)
            {
                Assert.IsTrue(toTestList.Contains(it));
            }
        }

        [TestMethod()]
        public void GetProductsByVendorNameTest()
        {
            var productsByVendorName = Tools.GetProductsByVendorName("bicycles");
            List<string> productNames = productsByVendorName.Select(n => n.Name).ToList();
            List<string> toTestList = new List<string>()
            {
                "Front Brakes", "Headset Ball Bearings", "HL Road Seat/Saddle", "LL Mountain Rim",
                "LL Mountain Seat/Saddle", "LL Road Rim", "ML Mountain Rim", "ML Mountain Seat/Saddle",
                "ML Road Rim", "Rear Brakes", "Thin-Jam Hex Nut 1", "Thin-Jam Hex Nut 10",
                "Thin-Jam Hex Nut 11", "Thin-Jam Hex Nut 12", "Thin-Jam Hex Nut 13", "Thin-Jam Hex Nut 14",
                "Thin-Jam Hex Nut 15", "Thin-Jam Hex Nut 16", "Thin-Jam Hex Nut 2", "Thin-Jam Hex Nut 3",
                "Thin-Jam Hex Nut 4", "Thin-Jam Hex Nut 5", "Thin-Jam Hex Nut 6", "Thin-Jam Hex Nut 7",
                "Thin-Jam Hex Nut 8", "Thin-Jam Hex Nut 9"
            };

            Assert.AreEqual(productsByVendorName.Count, toTestList.Count);
            foreach (var it in productNames)
            {
                Assert.IsTrue(toTestList.Contains(it));
            }
        }

        [TestMethod()]
        public void GetProductNamesByVendorNameTest()
        {
            List<Product> productsByVendorName = Tools.GetProductsByVendorName("Cycles");
            List<string> toTestList = productsByVendorName.Select(n => n.Name).ToList();
            List<string> productNamesByVendorName = Tools.GetProductNamesByVendorName("Cycles");

            // sprawdzamy czy listy mają równe długości
            Assert.AreEqual(toTestList.Count, productNamesByVendorName.Count);

            // sprawdzamy czy każdy element z productNamesByVendorName zawiera się w liście toTestList
            foreach (var it in productNamesByVendorName)
            {
                Assert.IsTrue(toTestList.Contains(it));
            }
        }

        [TestMethod()]
        public void GetProductVendorByProductNameTest()
        {
            /*
            select distinct v.Name from Purchasing.Vendor v 
            join Purchasing.ProductVendor pv on v.BusinessEntityID = pv.BusinessEntityID
            join Production.Product p on pv.ProductID = p.ProductID
            where p.Name like '%Crankarm%'
             */
            string productVendor = Tools.GetProductVendorByProductName("Crankarm");
            string toTestString =
                "Proseware, Inc.\n" +
                "Vision Cycles, Inc.\n" +
                "West Junction Cycles\n";

            Assert.AreEqual(productVendor, toTestString);
        }

        [TestMethod()]
        public void GetProductsWithNRecentReviewsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNRecentlyReviewedProductsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNProductsFromCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTotalStandardCostByCategoryTest()
        {
            Assert.Fail();
        }

    }
}