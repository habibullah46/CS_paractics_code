using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practics_program
{
    public class animal 
        {
        protected int  a = 90;
          protected    void dog1()
        {
            Console.WriteLine("dog is eating;");
          //  Console.WriteLine("the value of a  is : " + a);
        }
        }
    public class animal2:animal
    {
        private void dog()
        {
            Console.WriteLine("animal 2 dog is eating");
            Console.WriteLine("the value oe a " + a) ;
        }
     
          
        
        public static void main(string[] args)
        {
          animal2 ani = new animal2();
            ani.dog();
            
        }
      
    }
}
