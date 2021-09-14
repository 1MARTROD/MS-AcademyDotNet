using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Hacer un case

            Menu menu = new Menu();
            //menu.MenuUi();
            menu.SwitchForMenu();
            //Console.WriteLine("Create a new car");
            //var carCRUD = new CarCRUD();
            //carCRUD.CreateCar();
            //Console.WriteLine("Input a car Id to display a car");
            //carCRUD.ReadCar(Console.ReadLine());
            //Console.WriteLine("Edit a car by Id");
            //carCRUD.UpdateCar(Console.ReadLine());
            //Console.WriteLine("Delete a car by Id");
            ////TODO try to not convert. Instead set as a var in Car class
            //carCRUD.Delete(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
