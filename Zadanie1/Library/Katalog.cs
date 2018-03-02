using System;
using System.Collections.Generic;
using System.Text;


//klasa opisująca katalog książek
namespace Library
{
    class Katalog
    {
        //klucz główny
        public string Isbn
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public string Author
        {
            get; set;
        }
        public int ReleaseYear
        {
            get; set;
        }
    }
}
