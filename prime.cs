using System;
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("enter a number which to be check if it is prime or not");
        int n= Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i=1; i<=n/2;i++)
        {
            if (n % i == 0)
                count++;
        }

        if (count > 1)
            Console.WriteLine("not prime");
        else
            Console.WriteLine(" prime");

        Console.ReadLine();
    }

    }