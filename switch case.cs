

using System;
  
public class GFG 
{
  
    public static void Main(String[] args)
    { 
 
        Console.WriteLine("Type 1 for Factorial");
        Console.WriteLine("Type 2 for Fabonicci series");
        Console.WriteLine("Type 3 for Prime Number");
        int nitem = int.Parse(Console.ReadLine());
        switch (nitem) 
        {
  
        case 1:
              int i,fact=1,number;      
       Console.Write("Enter any Number: ");      
       number= int.Parse(Console.ReadLine());     
       for(i=1;i<=number;i++){      
        fact=fact*i;      
       }      
       Console.Write("Factorial of " +number+" is: "+fact);    
           
            break;
  
        case 2:
           int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            if(numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                
                Console.Write(firstNumber + " " + SecondNumber + " ");
                
                for(int j = 2; j < numberOfElements; j++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
            break;
  
        case 3:

             
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

            break;
  
        default:
            Console.WriteLine("No match found");
            break;
        }
        
    }
}