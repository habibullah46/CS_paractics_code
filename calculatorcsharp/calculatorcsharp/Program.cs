using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorcsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            float result = 0;
            Console.WriteLine("\n\n\t\t\t***CALCULATOR***");
            Console.Write("Enter ValueOne: ");
            float valueOne = float.Parse(Console.ReadLine());   
            Console.Write("Enter ValueTwo: ");
            float valueTwo=float.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter Your Choice\n1.ADD\n2.SUB\n3.MUL\n4.DIVID") ; 
            int  choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                    result= valueOne+valueTwo;
                    Console.WriteLine("Sum of Two number is : "+result);
                    Console.ReadLine();
                    break;
                case 2: 
                    result= valueOne-valueTwo;
                    Console.WriteLine("Subtraction of Two number is: " + result);
                    Console.ReadLine();
                    break;
                case 3:
                    result= valueOne*valueTwo;
                    Console.WriteLine("Multiplication of Two number is: " + result);
                    Console.ReadLine();
                    break;  
                case 4:
                    result = valueTwo / valueOne;
                    Console.WriteLine("Division of two number is: " + result);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Number ");
                    break;
                

                  
            }
            Console.ReadLine();

        }
    }
}
