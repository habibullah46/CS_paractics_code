using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Value One : ");
            int i = int.Parse(Console.ReadLine());
            if(i%2 == 0) 
            {
                Console.WriteLine("IT is evenNumber");
            }
            else
            {
                Console.WriteLine("It is not even number");
            }
             Console.ReadLine();
        }
    }
}

