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


        public string Isbn
        {
            get => isbn;
            set => isbn = value;
        }

        private string Title;

        public string Title1 { get => Title; set => Title = value; }

        private string Author;

        public string Author1 { get => Author; set => Author = value; }

        private int releaseYear;

        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }

    }
}
