using System;
using System.Collections.Generic;

namespace HomeworkCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Queue<int> intQueue = new Queue<int>();

            Console.WriteLine("Please enter three numbers to be added to the Queue");

            int firstInteger = int.Parse(Console.ReadLine());
            intQueue.Enqueue(firstInteger);

            int secondInteger = int.Parse(Console.ReadLine());
            intQueue.Enqueue(secondInteger);

            int thirdInteger = int.Parse(Console.ReadLine());
            intQueue.Enqueue(thirdInteger);
           
            Console.WriteLine("Would you like to add another number to the Queue press Y if you want to or N if you don't want to add another number");

            string yesOrNo = Console.ReadLine();

            if (yesOrNo == "Y".ToLower())
            {
                Console.WriteLine("Please enter another number to be added to the Queue");
                int anotherInteger = int.Parse(Console.ReadLine());
                intQueue.Enqueue(anotherInteger);

                Console.WriteLine("These are the numbers that you added to the Queue");

                foreach(int number in intQueue)
                {
                    Console.WriteLine(number);
                }
            }
            else if (yesOrNo == "N".ToLower())
            {
                Console.WriteLine("You have chosen not to add another number to the queue");
            }


            




            Console.ReadLine();
        }
    }
}
