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
        for (var i = 0; i < carList.Count; i++)
        {
            if (Convert.ToByte(idCar) == carList[i].IdCar)
            {
                Console.WriteLine($"Id Car: {carList[i].IdCar}");
                Console.WriteLine($"Availability: {carList[i].Availability}");
                Console.WriteLine($"Id plate: {carList[i].IdPlate}");
                Console.WriteLine($"Brand: {carList[i].Brand}");
                Console.WriteLine($"Model: {carList[i].Model}");
                Console.WriteLine($"Door number: {carList[i].Doors}");
                Console.WriteLine($"Colour: {carList[i].Colour}");
                Console.WriteLine($"Transmission type: {carList[i].Transmission}");
            }
        }
    }
    public void UpdateCar(string idCar)
    {
        carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);
        //TODO: implementar un foreach
        for (var i = 0; i < carList.Count; i++)
        {
            if (Convert.ToByte(idCar) == (carList[i].IdCar))
            {
                Console.WriteLine("You will update a car based on its Id");
                Console.WriteLine("Enter availability. Answer true or false");
                carList[i].Availability = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter colour:");
                carList[i].Colour = Console.ReadLine();
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
