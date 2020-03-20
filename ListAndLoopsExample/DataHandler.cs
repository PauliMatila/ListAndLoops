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

        public Person AddNewPersonToList()
        {
            Person person = CreatePerson();
            this.persons.Add(person);
            Console.WriteLine("Henkilö lisätty listaan");
            return person;
        }

        public void PrintPersonList()
        {
            if(this.persons.Count == 0)
            {
                Console.WriteLine("Henkilölista tyhjä.");
                return;
            }
            
            for (int i = 0; i < this.persons.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {this.persons[i].firstName} {this.persons[i].lastName}");
            }
        }

        public Person SelectPersonFromList()
        {
            PrintPersonList();
            Console.WriteLine("Syötä valittavan henkilön numero:");
            int selected = int.Parse(Console.ReadLine());
            return this.persons[selected - 1];
        }

        public Company CreateCompany()
        {
            Console.WriteLine("anna yrityksen nimi");
            string name = Console.ReadLine();
            Console.WriteLine("anna yrityksen maa");
            string country = Console.ReadLine();

            bool personIsSelected = false;

            Person contactPerson = null;

            while (!personIsSelected)
            {
                Console.Clear();

                Console.WriteLine("1) Valitse yhteyshenkilö listasta.");
                Console.WriteLine("2) Lisää uusi yhteyshenkilö.");
                Console.WriteLine("3) ei yhteyshenkilöä.");
                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        contactPerson = SelectPersonFromList();
                        personIsSelected = true;
                        break;
                    case 2:
                        contactPerson = AddNewPersonToList();
                        personIsSelected = true;
                        break;
                    case 3:
                        personIsSelected = true;
                        break;
                    default:
                        personIsSelected = false;
                        break;
                }
            }

            Company company = new Company(name, contactPerson, country);

            return company;
        }

        public Company AddNewCompanyToList()
        {
            Company company = CreateCompany();
            this.companies.Add(company);
            Console.WriteLine("Yritys lisätty listaan.");
            return company;
        }

        public void PrintCompanyList()
        {
            if (this.companies.Count == 0)
            {
                Console.WriteLine("Yrityslista on tyhjä.");
                return;
            }

            int i = 1;
            foreach (Company company in this.companies)
            {
                Console.WriteLine($"{i}.\tNimi:{company.name}");
                Console.WriteLine($"{i}.\tYhteyshenkilö:{company.contactPerson.firstName} {company.contactPerson.lastName}");
                i++;
            }
        }

        public Company SelectCompanyFromList()
        {
            PrintCompanyList();
            Console.WriteLine("syötä valittavan yrityksen numero:");
            int selected = int.Parse(Console.ReadLine());
            return this.companies[selected - 1];
        }

        public Coffee CreateCoffee()
        {
            Console.WriteLine("anna kahvin merkki:");
            string brand = Console.ReadLine();
            Console.WriteLine("anna kahvin hinta:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("anna paahto (1-5):");
            int paahto = int.Parse(Console.ReadLine());
            Roast roast = (Roast)paahto;

            Company importer = null;
            bool importerSelected = false;
            while (!importerSelected)
            {
                Console.Clear();

                Console.WriteLine("mikä on maahantuoja?");
                Console.WriteLine("1) Valitse yritys listasta.");
                Console.WriteLine("2) Uusi yritys.");
                int selected = int.Parse(Console.ReadLine());
                switch (selected)
                {
                    case 1:
                        Console.Clear();
                        importer = SelectCompanyFromList();
                        importerSelected = true;
                        break;
                    case 2:
                        Console.Clear();
                        importer = AddNewCompanyToList();
                        importerSelected = true;
                        break;
                    case 3:
                        Console.Clear();
                        importer = null;
                        importerSelected = true;
                        break;
                    default:
                        break;
                }
            }

            Coffee newCoffee = new Coffee(brand, price, roast, importer);
            return newCoffee;
        }

        public void AddNewCoffeeToList()
        {
            Coffee coffee = CreateCoffee();
            this.coffees.Add(coffee);
            Console.WriteLine("Kahvi lisättiin listaan.");
        }

        public void PrintCoffeeList()
        {
            if (this.coffees.Count == 0)
            {
                Console.WriteLine("Kahvi lista tyhjä.");
                return;
            }

            int i = 1;
            foreach (Coffee coffee in this.coffees)
            {
                Console.WriteLine($"{i}.\tMerkki:{coffee.brand}");
                Console.WriteLine($"\tPaahto:{coffee.brand}");
                Console.WriteLine($"\tMaahantuoja:{coffee.importer.name}");
                i++;
            }
        }

        public Coffee SelectCoffeeFromList()
        {
            PrintCoffeeList();
            Console.WriteLine("Syötä valittavan yrityksen numero:");
            int selected = int.Parse(Console.ReadLine());
            return this.coffees[selected - 1];
        }

        

        
    }
}
