using System;
using System.Collections.Generic;
using System.Text;
//klasa opisujaca wypozyczenia
namespace Library
{
    class Zdarzenie
    {
        private OpisStanu opisStanu;

        public OpisStanu OpisStanu
        {
            get => opisStanu;
            set => opisStanu = value;
        }

        public Wykaz wykaz;

        public Wykaz Wykaz
        {
            get => wykaz;
            set => wykaz = value;
        }

        private DateTime borrowTime;

        public DateTime BorrowTime
        {
            get => borrowTime;
            set => borrowTime = value;
        }

        private DateTime returnTime;

        public DateTime ReturnTime
        {
            get => returnTime;
            set => returnTime = value;
        }
    }
}
