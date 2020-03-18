using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkki.");
            var merkki = Console.ReadLine();
            //syötetään hinta, paahto 1-5.
           
            Coffee toReturn = new Coffee(merkki);
            toReturn.roast = (Coffee.Roast)1;
            toReturn.roast = (Coffee.Roast)2;
            toReturn.roast = (Coffee.Roast)3;
            toReturn.roast = (Coffee.Roast)4;
            toReturn.roast = (Coffee.Roast)5;
            return toReturn;
        }
        

        public Person CreatePerson()
        {
            Console.WriteLine("Anna henkilö.");
            var henkilö = Console.ReadLine();

            Person toReturn = new Person(henkilö);
            return toReturn;
        }
        //metodi luo persoonan
    }
}
