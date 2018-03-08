using System;
using System.Collections.Generic;
using System.Text;


//klasa opisująca katalog książek
namespace Library
{
    class Katalog
    {
        //klucz główny

        private string isbn;
        private string author;
        private int releaseYear;
        private string title;

        public string Isbn { get => isbn; set => isbn = value; }

        public string Author { get => author; set => author = value; }

        public string Title { get => title; set => title = value; }

        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
    }
}
