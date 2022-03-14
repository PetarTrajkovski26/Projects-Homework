using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number to sum then get average of");
            float firstInputNumber;
            bool isfirsInputNumberASuccess = float.TryParse(Console.ReadLine(), out firstInputNumber);

            Console.WriteLine("Enter Second Number to sum then get average of");
            float secondInputNumber;
            bool isSecondInputNumberASuccess = float.TryParse(Console.ReadLine(), out secondInputNumber);

            Console.WriteLine("Enter third number to sum then get the average of");
            float thirdInputNumber;
            bool isThirdInputNumberASuccess = float.TryParse(Console.ReadLine(), out thirdInputNumber);

            Console.WriteLine("Enter fourth number to sum then get the average of");
            float fourthInputNumber;
            bool isFourthInputNumberASuccess = float.TryParse(Console.ReadLine(), out fourthInputNumber);

            float sumOfAllFourNumbers = firstInputNumber + secondInputNumber + thirdInputNumber + fourthInputNumber;
            float averageOfAllFourNumbers = sumOfAllFourNumbers / 4;
            Console.WriteLine("The average of all four numbers is:" + averageOfAllFourNumbers);


            Console.ReadLine();
        }
    }
}
