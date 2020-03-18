using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Person
    {
        public string name;
        public string lastName;
        public string eMail;
        public int phoneNumber;

        public Person(string name, string lastName, string eMail, int phoneNumber)
        {
            this.name = name;
            this.lastName = lastName;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
        }
    }
}
