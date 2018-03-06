using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        private string isbn;
        private string title;
        private string author;
        private int releaseYear;

        public string Isbn
        {
            get => isbn;
            set => isbn = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public int ReleaseYear
        {
            get => releaseYear;
            set => releaseYear = value;
        }
    }
}
