using System;

class Program
{
    static int[] numbers = new int[100];
    static int size = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add number");
            Console.WriteLine("2. Remove number");
            Console.WriteLine("3. Sort numbers");
            Console.WriteLine("4. Insert number");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice! Please try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddNumber();
                    break;
                case 2:
                    RemoveNumber();
                    break;
                case 3:
                    SortNumbers();
                    break;
                case 4:
                    InsertNumber();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }

    static void AddNumber()
    {
        if (size >= numbers.Length)
        {
            Console.WriteLine("Array is full! Cannot add more numbers.");
            return;
        }

        Console.Write("Enter a number to add: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid number! Please try again.");
            return;
        }

        numbers[size] = number;
        size++;
        Console.WriteLine("Number added successfully!");
    }

    static void RemoveNumber()
    {
        if (size == 0)
        {
            Console.WriteLine("Array is empty! Cannot remove numbers.");
            return;
        }

        Console.Write("Enter the index of the number to remove: ");
        int index;
        if (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= size)
        {
            Console.WriteLine("Invalid index! Please try again.");
            return;
        }

        for (int i = index; i < size - 1; i++)
        {
            numbers[i] = numbers[i + 1];
        }
        size--;
        Console.WriteLine("Number removed successfully!");
    }

    static void SortNumbers()
    {
        if (size == 0)
        {
            Console.WriteLine("Array is empty! Cannot sort numbers.");
            return;
        }

        Array.Sort(numbers, 0, size);
        Console.WriteLine("Numbers sorted successfully!");
    }

    static void InsertNumber()
    {
        if (size >= numbers.Length)
        {
            Console.WriteLine("Array is full! Cannot insert more numbers.");
            return;
        }

        Console.Write("Enter a number to insert: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid number! Please try again.");
            return;
        }

        Console.Write("Enter the index to insert at: ");
        int index;
        if (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index > size)
        {
            Console.WriteLine("Invalid index! Please try again.");
            return;
        }

        for (int i = size; i > index; i--)
        {
            numbers[i] = numbers[i - 1];
        }
        numbers[index] = number;
        size++;
        Console.WriteLine("Number inserted successfully!");
    }
}
