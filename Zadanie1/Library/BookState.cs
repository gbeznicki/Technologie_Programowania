using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BookState
    {
        private string bookDescription;
        private DateTimeOffset dateOfPurchase;
        private Book book;

        public string BookDescription
        {
            get => bookDescription;
            set => bookDescription = value;
        }

        public DateTimeOffset DateOfPurchase
        {
            get => dateOfPurchase;
            set => dateOfPurchase = value;
        }

        public Book Book
        {
            get => book;
            set => book = value;
        }
    }
}
