using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First Number");
            int firstNumber;
            bool isFirstNumberASuccess = int.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Enter Second Number");
            int secondNumber;
            bool isSecondNumberASuccess = int.TryParse(Console.ReadLine(), out secondNumber);

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("The first number has swapped it's place with the second number:" + firstNumber);
            Console.WriteLine("The second number has swapped it's place with the first number:" + secondNumber);
           
            
            Console.ReadLine();
        }
    }
}
