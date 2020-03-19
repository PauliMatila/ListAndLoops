using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();
        public List<Company> companies = new List<Company>();
        
        
        public Person CreatePerson()
        {
            Console.WriteLine("anna etunimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("anna sukunimi:");
            string lastName = Console.ReadLine();
            Console.WriteLine("anna sähköposti:");
            string eMail = Console.ReadLine();
            Console.WriteLine("anna puhelinnumero:");
            string phoneNumber = Console.ReadLine();

            Person person = new Person(firstName, lastName, eMail, phoneNumber);

            return person;
        }

        public void AddPersonToList()
        {
            var person = CreatePerson();
            this.persons.Add(person);
            Console.WriteLine("Henkilö lisätty listaan");
        }

        public void PrintPersonList()
        {
            for (int i = 0; i < this.persons.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {this.persons[i].firstName} {this.persons[i].lastName}");
            }
        }

        public Person SelectPersonFromList()
        {
            PrintPersonList();
            Console.WriteLine("Syötä valittavan henkilön numero:");
            var selected = int.Parse(Console.ReadLine());
            return this.persons[selected-1];
        }
        //metodi luo persoonan
    }
}
