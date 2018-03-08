using System;
using System.Collections.Generic;
using System.Text;

//klasa opisująca stan książek
namespace Library
{
    class OpisStanu
    {
        private string bookDescritpion;
        private DateTime dateOfPurchase;
        private Katalog catalogue;

        public string BookDescritpion { get => bookDescritpion; set => bookDescritpion = value; }

        public DateTime DateOfPurchase
        {
            get => dateOfPurchase;
            set => dateOfPurchase = value;
        }

        public Katalog Catalogue
        {
            get => catalogue;
            set => catalogue = value;
        }

    }
}
