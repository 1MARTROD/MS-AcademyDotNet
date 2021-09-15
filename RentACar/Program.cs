using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Car menu");
            Menu menu = new Menu();
            menu.SwitchForMenu();

        }
    }
}
