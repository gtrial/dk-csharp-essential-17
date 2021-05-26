using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    internal static class Program
    {
        private class Car
        {
            public string Brand { get; }
            public string Model { get; }
            public string Year { get; }
            public string Color { get; }

            public Car(string brand, string model, string year, string color)
            {
                Brand = brand;
                Model = model;
                Year = year;
                Color = color;
            }
        }

        private class CarOwner
        {
            public string Model { get; }
            public string OwnerName { get; }
            public string Phone { get; }

            public CarOwner(string model, string ownerName, string phone)
            {
                Model = model;
                OwnerName = ownerName;
                Phone = phone;
            }
        }

        private static void Main()
        {
            var cars = new List<Car>
            {
                new Car("a", "a", "2010", "red"),
                new Car("b", "b", "2011", "green"),
                new Car("c", "c", "2012", "green")
            };
            var carOwners = new List<CarOwner>
            {
                new CarOwner("a", "name1", "111-11"),
                new CarOwner("b", "name2", "111-12")
            };
            var query = from carOwner in carOwners
                join car in cars on carOwner.Model equals car.Model
                where carOwner.OwnerName == "name1"
                select new
                {
                    car.Brand,
                    carOwner.Model,
                    car.Year,
                    car.Color,
                    carOwner.OwnerName,
                    carOwner.Phone
                };
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Brand} {item.Model} {item.Year} {item.Color} {item.OwnerName} {item.Phone}");
            }
        }
    }
}