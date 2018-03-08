using System;
using System.Collections.Generic;
using System.Text;


//klasa opisująca wykaz klientów
namespace Library
{
    class Wykaz
    {
        private int _age;
        private string _firstName;
        private string _surname;
        private string _telephone;

        public int Age
        {
            get => _age; set => _age = value;
        }

        public string FirstName
        {
            get => _firstName; set => _firstName = value;
        }

        public string Surname
        {
            get => _surname; set => _surname = value;
        }

        public string Telephone
        {
            get => _telephone; set => _telephone = value;
        }

    }
}
