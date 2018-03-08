using System;
using System.Collections.Generic;
using System.Text;
//klasa opisujaca wypozyczenia
namespace Library
{
    class Zdarzenie
    {
        private OpisStanu opisStanu;
        public Wykaz wykaz;
        private DateTime borrowTime;
        private DateTime returnTime;

        public OpisStanu OpisStanu
        {
            get => opisStanu;
            set => opisStanu = value;
        }

        public Wykaz Wykaz
        {
            get => wykaz;
            set => wykaz = value;
        }

        public DateTime BorrowTime
        {
            get => borrowTime;
            set => borrowTime = value;
        }

        public DateTime ReturnTime
        {
            get => returnTime;
            set => returnTime = value;
        }
    }
}
