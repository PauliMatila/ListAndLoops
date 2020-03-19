using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string eMail;
        public string phoneNumber;

        public Person(string firstName, string lastName, string eMail, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
        }
    }
}
