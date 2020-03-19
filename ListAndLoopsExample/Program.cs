using System;
using System.Collections.Generic;

namespace ListAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dh = new DataHandler();

            dh.AddPersonToList();
            dh.PrintPersonList();
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Valitse henkilö");
            var person = dh.SelectPersonFromList();
            Console.WriteLine($"Valittu : {person.firstName} {person.lastName} {person.eMail}");

            //var dh = new DataHandler();
            //var kahvi = dh.CreateCoffee();
            //dh.coffees.Add(kahvi);

            //var paketti = new Coffee("pressa", 3.4, Coffee.Roast.light, "joku");
            //Console.WriteLine($"enum:{(int)paketti.roast}");


            //var paketti1 = new Coffee("Presidentti");
            //var paketti2 = new Coffee("Kulta Katriina");
            //var paketti3 = new Coffee("Brazil");
            //var paketti4 = new Coffee("Löfberg");

            //List<Coffee> coffees = new List<Coffee>();
            //coffees.Add(paketti1);
            //coffees.Add(paketti2);
            //coffees.Add(paketti3);
            //coffees.Add(paketti4);

            ////Console.WriteLine(coffees[0].brand);

            //foreach (var paketti in coffees)
            //{
            //    Console.WriteLine($"Merkki {paketti.brand}");
            //}


            //for (int i = 0; i < coffees.Count; i++)
            //{
            //    Console.WriteLine($"{i}. Merkki : {coffees[i].brand}");
            //}



            //Company -luokka. nimi, yhteyshenkilö(luokka person), maa
            //person -luokka. etunimi, sukunimi, puhelinnumero, email
            //DataHandler - luokka. list<cofee>, list<person>
            //metodi joka kysyy kahvin merkin, hinnan, roast- asteen -> luo näistä instanssin Coffee -> lisää ko. instanssin listaan.

        }
    }

    //kahvi
    //-merkki, hinta, paahto, maahantuoja
    //constructorit ilman parametreja, pelkällä nimellä, kaikilla atribuuteilla

    

    
}
