using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practics_program
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    car Car = new car();
        //    Car.information_about_car();
        //    Console.ReadLine();

        //}
    }
    class car
    {
        private string model;
        private string color;
        private string price;
        public  void information_about_car()
        {
            Console.WriteLine("Model: "+model);
            Console.WriteLine("color: " + color);
            Console.WriteLine("price: "+ price);

        }
        static void Main(string[] args)
        {
            car Car = new car();
            Car.price = "202123";
            Console.WriteLine(Car.price);
            
        }
    }
}
