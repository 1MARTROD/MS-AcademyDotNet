using Newtonsoft.Json;
using RentACar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

public class CarCRUD
{
    List<Car> carList = new List<Car>();
    public static string fileName = ConfigurationManager.AppSettings[("jsonFileCars")];
    Car car = new Car();
    public static string path = ConfigurationManager.AppSettings[("path")];
    string jsonString = File.ReadAllText(fileName);

    public void CreateCar()
    {
        carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);
        car.IdCar = Convert.ToByte(carList.Count + 1);
        Console.WriteLine($"creating car with Id {car.IdCar}");
        car.Availability = true;
        Console.WriteLine("Enter ID Plate");
        car.IdPlate = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter car brand:");
        car.Brand = Console.ReadLine();
        Console.WriteLine("Enter car model:");
        car.Model = Console.ReadLine();
        Console.WriteLine("Enter the colour:");
        car.Colour = Console.ReadLine();
        Console.WriteLine("Enter doors amount:");
        car.Doors = Console.ReadLine();
        Console.WriteLine("Enter transmission type:");
        car.Transmission = Console.ReadLine();
        carList.Add(car);
        Console.WriteLine("Car added successfully!");
        string json = JsonConvert.SerializeObject(carList);
        System.IO.File.WriteAllText(path, json);
    }
    public void ReadCar(String idCar)
    {
        carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);
        //TODO: implementar un foreach
        foreach (Car car in carList)
        {
            if (Convert.ToByte(idCar) == car.IdCar)
            {
                Console.WriteLine($"Id Car: {car.IdCar}");
                Console.WriteLine($"Availability: {car.Availability}");
                Console.WriteLine($"Id plate: {car.IdPlate}");
                Console.WriteLine($"Brand: {car.Brand}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Door number: {car.Doors}");
                Console.WriteLine($"Colour: {car.Colour}");
                Console.WriteLine($"Transmission type: {car.Transmission}");
            }
        }
    }
    public void UpdateCar(string idCar)
    {
        carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);
        //TODO: implementar un foreach
        foreach (Car car in carList)
        {
            if (Convert.ToByte(idCar) == (car.IdCar))
            {
                Console.WriteLine("You will update a car based on its Id");
                Console.WriteLine("Enter availability. Answer true or false");
                car.Availability = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter colour:");
                car.Colour = Console.ReadLine();
                Console.WriteLine("Car Updated successfully!");
                string json = JsonConvert.SerializeObject(carList);
                System.IO.File.WriteAllText(path, json);
            }
        }
    }

    public void Delete(int idCar)
    {
        carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);
        foreach (var element in carList.Where(element => idCar.Equals(element.IdCar)))
        {
            Console.WriteLine($"Id car: {idCar} deleted!");
            carList.Remove(element);
            string json = JsonConvert.SerializeObject(carList);
            System.IO.File.WriteAllText(path, json);
            break;
        }
    }
}
