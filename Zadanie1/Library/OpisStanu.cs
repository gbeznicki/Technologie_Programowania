using System;
using System.Collections.Generic;
using System.Text;

//klasa opisująca stan książek
namespace Library
{
    class OpisStanu
    {
        public string BookDescription
        {
            get; set;
        }

        public DateTime DateOfPurchase
        {
            get; set;
        }

        public Katalog Catalogue
        {
            get; set;
        }
    }
}
