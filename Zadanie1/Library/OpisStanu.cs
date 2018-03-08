using System;
using System.Collections.Generic;
using System.Text;

//klasa opisująca stan książek
namespace Library
{
    class OpisStanu
    {
        private string bookDescritpion;

        public string BookDescritpion { get => bookDescritpion; set => bookDescritpion = value; }

        private DateTime dateOfPurchase;

        public DateTime DateOfPurchase
        {
            get => dateOfPurchase;
            set => dateOfPurchase = value;
        }

        private Katalog catalogue;

        public Katalog Catalogue
        {
            get => catalogue;
            set => catalogue = value;
        }

    }
}
