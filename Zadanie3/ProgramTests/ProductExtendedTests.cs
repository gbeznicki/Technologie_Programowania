using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tests
{
    [TestClass()]
    public class ProductExtendedTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Tools.DataContext = new BazaDanychDataContext();
        }

        [TestMethod()]
        public void PodzielNaStronyTest()
        {
            int rozmiarStrony = 5;
            int nrStrony = 5;
            int poczatekPrzedzialu = (nrStrony - 1) * rozmiarStrony;
            List<Product> productsByVendorName = Tools.GetProductsByVendorName("bicycles");
            int ileRekordow = productsByVendorName.Count;

            List<Product> productsPage =
                Tools.GetProductsByVendorName("bicycles")
                    .PodzielNaStrony(rozmiarStrony, nrStrony);

            if (ileRekordow > nrStrony * rozmiarStrony)
            {
                Assert.AreEqual(productsPage.Count, rozmiarStrony);
            }
            else
            {
                Assert.AreEqual(productsPage.Count, ileRekordow - rozmiarStrony * nrStrony);
            }


            for (int i = poczatekPrzedzialu; i < poczatekPrzedzialu + rozmiarStrony; i++)
            {
                Assert.IsTrue(productsPage.Contains(productsByVendorName[i]));
            }

        }
    }
}