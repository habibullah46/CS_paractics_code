using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public int FindMax (int valueOne, int valueTwo)
        {
            int result = 0; 
            if(valueOne > valueTwo) 
            {
               result= valueOne;
            }
            else
            {
                result= valueTwo;   
            }
            return result;  
        }
        static void Main(string[] args)
        {
            Console.Write("Enter ValueOne: ");
            int valueone= int.Parse(Console.ReadLine());
            Console.Write("Enter valueTwo: ");
            int valuetwo=int .Parse(Console.ReadLine());   
          Program max = new Program();
            Console.Write("Maximum number is: ");
            Console.WriteLine(max.FindMax(valueone, valuetwo));
            Console.ReadLine();
        }
    }
}
