using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

            //Test Data:
            // Enter the First number: 10
            // Enter the Second number: 15
            // Enter the Operation: +
            //  Expected Output:
            //  The result is: 25

            Console.WriteLine("Enter first number");
            int firstNumber;
            bool ifSuccess = int.TryParse(Console.ReadLine(), out firstNumber);
            
            Console.WriteLine("Enter second number");
            int secondNumber;
            bool isInputNumberASuccess = int.TryParse(Console.ReadLine(), out secondNumber);
           
            Console.WriteLine("What operation would you like to be done? ( +, - , * , / )");
            char inputOperator = Convert.ToChar(Console.ReadLine());
            int sumOperation;
            int subtractOperation;
            int multiplyOperation;
            int divideOperation;

            if (inputOperator == '+')
             {
                sumOperation = firstNumber + secondNumber;
                Console.WriteLine(sumOperation);
             }else if (inputOperator == '-')
             {
                subtractOperation = firstNumber - secondNumber;
                Console.WriteLine(subtractOperation);
             }else if (inputOperator == '*')
             {
                multiplyOperation = firstNumber * secondNumber;
                Console.WriteLine(multiplyOperation);
             }else if (inputOperator == '/')
              {
                divideOperation = firstNumber / secondNumber;
                Console.WriteLine(divideOperation);
             }else
              {
                Console.WriteLine("Wrong Operation Entered!!!");
              }

            

            Console.ReadLine();
        }
    }
}
