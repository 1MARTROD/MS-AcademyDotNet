using Newtonsoft.Json;
using RentACar;
using System;
using System.Collections.Generic;
using System.IO;



    public class CarCRUD
    {
        List<Car> carList = new List<Car>();
        public static string fileName = @"..\..\..\Data\Cars.json";
        Car car = new Car();
        //TODO set relative path
        public static string path = @"C:\Users\mrodriguez\Documents\MS-AcademyDotNet\MS-AcademyDotNet\RentACar\Data\Cars.json";
        string jsonString = File.ReadAllText(fileName);

        public void CreateCar()
        {
            //TODO add automatic IdCar
            carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);
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
        public void ReadCar(string Id)
        {
            carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);
            for (var i = 0; i < carList.Count; i++)
            {
                if (Convert.ToByte(Id) == carList[i].IdPlate)
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
        public void Update(string Id)
        {
            carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);
            for (var i = 0; i < carList.Count; i++)
            {
                if (Convert.ToByte(Id) == (carList[i].IdPlate))
                {
                    //TODO When IdCar is implemented delete comments
                    //Console.WriteLine("You will update a car based on its Id");
                    Console.WriteLine("Enter ID Plate");
                    carList[i].IdPlate = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Enter car brand:");
                    carList[i].Brand = Console.ReadLine();
                    Console.WriteLine("Enter car model:");
                    carList[i].Model = Console.ReadLine();
                    Console.WriteLine("Enter colour:");
                    carList[i].Colour = Console.ReadLine();
                    Console.WriteLine("Enter doors amount:");
                    carList[i].Doors = Console.ReadLine();
                    Console.WriteLine("Enter transmission type:");
                    carList[i].Transmission = Console.ReadLine();
                    Console.WriteLine("Car Updated successfully!");
                    string json = JsonConvert.SerializeObject(carList);
                    System.IO.File.WriteAllText(path, json);

                }
            }
        }

        public void Delete(string IdPlate)
        {
            carList = JsonConvert.DeserializeObject<List<Car>>(jsonString);

            foreach (Car element in carList)
            {
                if (IdPlate.Equals(element.IdPlate))
                {
                    Console.WriteLine($"Id plate: {IdPlate} deleted!");
                    carList.Remove(element);
                    string json = JsonConvert.SerializeObject(carList);
                    System.IO.File.WriteAllText(path, json);
                    break;
                }
            }
        }
    }
