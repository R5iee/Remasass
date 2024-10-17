using System;

class Program
{
    static void Main()
    {
        int firstNumber, secondNumber;

        /
        while (true)
        {
            Console.Write("Enter the first number (1 to 12): ");
            firstNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= 1 && firstNumber <= 12)
                break;
            else
                Console.WriteLine("Please enter a number between 1 and 12.");
        }

        
        while (true)
        {
            Console.Write("Enter the second number (1 to 12): ");
            secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber >= 1 && secondNumber <= 12)
                break;
            else
                Console.WriteLine("Please enter a number between 1 and 12.");
        }

        
        int result = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
