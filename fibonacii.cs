using System;
class Program
    {

  static  int fib(int a)
    {
        if (a > 1)
            return fib(a - 1) + fib(a - 2);
        else if (a == 1)
            return 1;
        else
            return 0;
    }
    static void Main(string[] args)
        {
         Console.WriteLine("enter a number where up to be print fibonacci series :");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(fib(i));

        }
        Console.ReadLine();


        }
    }