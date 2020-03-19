using System;
using System.Collections.Generic;
using System.Text;
using static ListAndLoopsExample.Coffee;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();
        public List<Company> companies = new List<Company>();

       
        public Coffee CreateCoffee()
        {
            Console.WriteLine("anna merkki:");
            string brand = Console.ReadLine();
            Console.WriteLine("anna hinta:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("anna paahto: (1-5)");
            int paahto = int.Parse(Console.ReadLine());
            Roast roast = (Roast)paahto;
            Console.WriteLine("anna maahantuoja:");
            string importer = Console.ReadLine();

            Coffee coffee = new Coffee(brand, price, roast, importer);

            return coffee;
        }

        public void AddCoffeeToList()
        {
            this.coffees.Add(CreateCoffee());
        }

        public void PrintCoffeeList()
        {
            for (int i = 0; i < this.coffees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {coffees[i].brand} {coffees[i].price} {coffees[i].roast} {coffees[i].importer}");
            }
        }

        public Coffee SelectCoffeeFromList()
        {
            PrintCoffeeList();
            Console.WriteLine("Syötä valittavan kahvin numero:");
            int selected = int.Parse(Console.ReadLine());
            return this.coffees[selected - 1];
        }

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

        public Company CreateCompany()
        {
            Console.WriteLine("anna yrityksen nimi");
            string name = Console.ReadLine();
            Console.WriteLine("anna yrityksen maa");
            string country = Console.ReadLine();

            Console.WriteLine("Valitse yhteyshenkilö listasta");
            Person contactPerson = SelectPersonFromList();
            
            Company company = new Company(name, contactPerson, country);

            return company;
        }

        public void AddCompanyToList()
        {
            var company = CreateCompany();
            this.companies.Add(company);
            Console.WriteLine("Yritys lisätty listaan.");
        }

        public void PrintCompanyList()
        {
            int i = 1;
            foreach (Company company in this.companies)
            {

                Console.WriteLine($"{i}.\tNimi: {company.name} \tMaa: {company.country}");
                Console.WriteLine($"\tYhteyshenkilö: {company.contactPerson.firstName} {company.contactPerson.lastName} \tSähköposti: {company.contactPerson.eMail} \tPuhelinnumero: {company.contactPerson.phoneNumber}");
                i++;
            }
        }

        public Company SelectCompanyFromList()
        {
            PrintCompanyList();
            Console.WriteLine("syötä valittavan yrityksen numero:");
            var selected = int.Parse(Console.ReadLine());
            return this.companies[selected - 1];
        }
        //metodi luo persoonan
    }
}
