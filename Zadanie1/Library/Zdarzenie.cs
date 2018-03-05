using System;
using System.Collections.Generic;
using System.Text;
//klasa opisujaca wypozyczenia
namespace Library
{
    public class Zdarzenie
    {
        public OpisStanu OpisStanu { get; set; }

        public Wykaz Wykaz { get; set; }

        public DateTime BorrowTime { get; set; }

        public DateTime ReturnTime { get; set; }
    }
}
