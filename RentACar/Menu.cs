using System;

namespace RentACar
{
    public class Menu
    {
        public void MenuUi()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Enter a number for option");
            Console.WriteLine("=========================");
            Console.WriteLine("1 to add a car");
            Console.WriteLine("2 to edit a car by Id");
            Console.WriteLine("3 to delete a car by Id");
            Console.WriteLine("4 to show a car by Id");
            Console.WriteLine("5 to exit");
            Console.WriteLine("=========================");
        }

        public bool SwitchForMenu()
        {
            bool exit = false;

            while (!exit)
            {
                var car = new Car();
                MenuUi();
                int option = Convert.ToByte(Console.ReadLine());
                var carCRUD = new CarCRUD();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Option 1 selected. Add a car ");
                      //  carCRUD.CreateCar();
                        break;
                    case 2:
                        Console.WriteLine("Option 2 selected. Edit a car by Id");
                    //    carCRUD.UpdateCar(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Option 3 selected. Delete a car by Id");
                      //  carCRUD.Delete(Convert.ToInt16(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Option 4 selected. Show a car by Id");
                        car = carCRUD.Read(Convert.ToInt16(Console.ReadLine()));
                        Console.WriteLine($"Id Car: {car.IdCar}");
                        Console.WriteLine($"Availability: {car.Availability}");
                        Console.WriteLine($"Id plate: {car.IdPlate}");
                        Console.WriteLine($"Brand: {car.Brand}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Door number: {car.Doors}");
                        Console.WriteLine($"Colour: {car.Colour}");
                        Console.WriteLine($"Transmission type: {car.Transmission}");
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Select an option");
                        break;

                }
            }
            return exit;
        }

    }
}