using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class MainMenu
    {
        public DataHandler dataHandler;

        public MainMenu(DataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }
        
        public void OpenMainManu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }
        
        public bool ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Valitse vaihtoehto:");
            Console.WriteLine("1) Lisää yhteyshenkilö.");
            Console.WriteLine("2) Lisää yritys.");
            Console.WriteLine("3) Lisää kahvi.");
            Console.WriteLine("4) Näytä kaikki yhteyshenkilöt.");
            Console.WriteLine("5) Näytä kaikki yritykset.");
            Console.WriteLine("6) Näytä kaikki kahvit.");
            Console.WriteLine("0) Exit");
            int selected = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (selected)
            {
                case 1:
                    dataHandler.AddNewPersonToList();
                    break;
                case 2:
                    dataHandler.AddNewCompanyToList();
                    break;
                case 3:
                    dataHandler.AddNewCoffeeToList();
                    break;
                case 4:
                    dataHandler.PrintPersonList();
                    break;
                case 5:
                    dataHandler.PrintCompanyList();
                    break;
                case 6:
                    dataHandler.PrintCoffeeList();
                    break;
                case 0:
                    return false;
                default:
                    Console.Clear();
                    return true;

            }
            return true;
        }
    }
}
