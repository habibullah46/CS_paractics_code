using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshap
{
    public  class calculator
    {
       public  int valueOne;
       public int valueTwo;
       public  int result;

     public  void add()
        {
            result = valueOne + valueTwo;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public void sub()
        {
            result = valueOne - valueTwo;   
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void mul()
        {
            result = valueOne * valueTwo;   
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void divid()
        {
            result = valueOne / valueTwo;          
            Console.WriteLine(result);  
            Console.ReadLine();
        }
    }
}
