using System;
 

    class Program
    {
        static void Main()
        {
            int a;
            Console.Write("Enter a Number : ");
            a = int.Parse(Console.ReadLine());
          
            if(a==0 || a==1)
            
            {
                Console.Write("Entered Number is not valid Number");
                          }
             else if (a % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
               
            }
            else
            
            {
                Console.Write("Entered Number is odd Number");
               
            }

        }
    }
