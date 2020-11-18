﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public string Name { get; set; }
        public bool HasNuts { get; set; }                               // <-- properties
        public double GramsOfFlour { get; set; }

        public Cookie()
        {

        }
        public Cookie(string name)
        {
            Name = name;
        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour, int numberOfChocolateChips)
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
            //setting property equal to parameter
        }
    }

    public enum VehicleType { Car, Truck, Van, Motercycle, Spaceship, Plane, Boat }

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle()
        {

        }
    }
    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }
    }
}
