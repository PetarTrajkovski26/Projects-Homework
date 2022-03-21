using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] studentsArrayG1 =new string[] { "Petar", "Marko", "Nikola", "Trajce", "Mario" };
            string[] studentsArrayG2 =new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

           Console.WriteLine("Enter student group (Either 1 or 2)");
           bool studentGroupSuccess = int.TryParse(Console.ReadLine(), out int studentGroup);
           
            if (studentGroupSuccess)
            {
                if (studentGroup == 1)
                {
                    foreach(string name in studentsArrayG1)
                    {
                        Console.WriteLine(name);
                    }

                }else if (studentGroup == 2)
                {
                    foreach(string name in studentsArrayG2)
                    {
                        Console.WriteLine(name);
                    }
                }

            }




            Console.ReadLine();
        }
    }
}
