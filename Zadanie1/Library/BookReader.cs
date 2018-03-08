using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BookReader
    {
        private int age;
        private string firstName;
        private string lastName;
        private string telephone;

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Telephone
        {
            get => telephone;
            set => telephone = value;
        }
    }
}
