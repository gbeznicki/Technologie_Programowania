using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Event
    {
        private BookState bookState;
        private BookReader bookReader;
        private DateTimeOffset borrowDate;
        private DateTimeOffset returnDate;

        public BookState BookState
        {
            get => bookState;
            set => bookState = value;
        }

        public BookReader BookReader
        {
            get => bookReader;
            set => bookReader = value;
        }

        public DateTimeOffset BorrowDate {
            get => borrowDate;
            set => borrowDate = value;
        }

        public DateTimeOffset ReturnTime {
            get => returnDate;
            set => returnDate = value;
        }
    }
}
