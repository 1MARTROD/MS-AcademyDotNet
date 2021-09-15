using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new car");
            var carCRUD = new CarCRUD();
            carCRUD.CreateCar();
            Console.WriteLine("Input a car Id to display a car");
            carCRUD.ReadCar(Console.ReadLine());
        }
    }
}
