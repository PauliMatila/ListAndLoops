using System;
using System.Collections.Generic;

namespace ListAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {

            DataHandler dh = new DataHandler();
            
            MainMenu mainMenu = new MainMenu(dh);
            mainMenu.OpenMainManu();
        }
    }
}
