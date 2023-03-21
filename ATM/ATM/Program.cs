using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;


namespace ATM
{
    internal class Program
    {
       

        public void wellCome()
        {

            Console.WriteLine("\n\n\n     \t\t\t\t************");
            Console.WriteLine("\t\t*****************  WELL COME  ******************");
            Console.WriteLine("              \t                 *************");
        }
        public void Title()
        {

            Console.WriteLine("\n\n\n     \t\t\t\t************");
            Console.WriteLine("\t\t***************** To  ATM  ******************");
            Console.WriteLine("              \t                 *************");
        }
        static void Main(string[] args)
        {
            Program well = new Program();
            well.wellCome();
            well.Title();
            string userName = "HABIBULLAH";
            Console.WriteLine("\n\n\t\t\t\t\tUSER NAME: HABIBULLAH");
            Console.Write("Please Enter Your Pin Code: ");
            int pasword = 1234;
            int password = int.Parse(Console.ReadLine());
            if(password == pasword)
            {
                int total_Amount = 15000;
                Console.WriteLine("Enter Your Choice\n1.Cash Withdraw \n2.Transfer\n3.Blance inquary");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter Your Ammount: ");
                        int amount = Convert.ToInt32(Console.ReadLine());  
                        if(amount<total_Amount)
                        {
                            Console.WriteLine("You withdraw "+amount+("PKR From "+userName)+" Account");
                            Console.WriteLine("THANK YOU SO MUCH FOR YOUR COOPERATION!!!");
                          
                        }
                        else
                        {
                            Console.WriteLine("SORRY there is only " + total_Amount + ("PKR in your account"));
                            Console.WriteLine("PLEASE TRY AGAIN LEATER!!");
                        }
                        break;
                        
                    case 2:
                        Console.Write("Please Enter Your Account number: ");
                        int accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Ammount: ");
                         amount = Convert.ToInt32(Console.ReadLine());   
                        if(amount<total_Amount )
                        {
                            Console.Write("Please Enter Reciever Account Number: ");
                            int r_AccountNumber=int.Parse(Console.ReadLine());
                            Console.WriteLine("You are transfering "+amount+("PKR From  "+userName+(" Account To  "+" "+r_AccountNumber+"Account")));
                            Console.WriteLine("Are u sure u want to transfer 1 for Yes and  0 for No........");
                            choice =int .Parse (Console.ReadLine());
                            if(choice == 1)
                            {
                                Console.WriteLine("Transfer Successfully!!!\nTHANK YOU SO MUCH FOR YOUR COOPERATAION");
                            }
                            else
                            {
                                Console.WriteLine("Transection Failed!!!!!!!!!!!");
                            }
                          
                        }
                        else
                        {
                            Console.WriteLine("SORRY there is only " + total_Amount + ("PKR in your account"));
                            Console.WriteLine("PLEASE TRY AGAIN LEATER!!");
                        }
                        break;
                      case 3:
                        Console.WriteLine("Your Balance is : "+total_Amount);
                        Console.WriteLine("THANK YOU SO MUCH!!!!!!!!");
                        break;
                }

            }
            Console.ReadLine();


        }
    }
}
