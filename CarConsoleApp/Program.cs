// See https://aka.ms/new-console-template for more information
using CarClassLibrary;
using System;

namespace CarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine("Car c is as follows " + c.Make + " " + c.Model + " " + c.Price);
        }
    }
}