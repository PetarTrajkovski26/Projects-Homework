using HomeworkClass09Linq.ClassModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkClass09Linq
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more

			List<string> personOver50 = people
								.Where(x => x.Age >= 50)
								.Select(x=>x.FirstName)
								.ToList();
			//personOver50.ForEach(x => Console.WriteLine(x));


			// Task 02
			// all people name starts with B
			List<Person> personNameStartsWithB = people
										.Where(x => x.FirstName.StartsWith("B"))
										.ToList();
			//personNameStartsWithB.ForEach(x => Console.WriteLine(x.FirstName));


			// Task 03
			// first person whose surname starts with T
			List<Person> personSurnameStartsWithT = people
											.Where(x => x.LastName.StartsWith("T"))
											.ToList();
			//personSurnameStartsWithT.ForEach(x => Console.WriteLine(x.LastName));

			// Task 04
			// find youngest and oldest person
			var youngestPerson = people
								 .Where(x => x.Age == people.Select(x => x.Age).Min())
								 .FirstOrDefault();
            //Console.WriteLine("The youngest person in the list is {0}", youngestPerson.FirstName);

			var oldestPerson = people
								  .Where(x => x.Age == people.Select(x => x.Age).Max())
								  .FirstOrDefault();
            //Console.WriteLine("The oldest person in the list is {0}", oldestPerson.FirstName);

			// Task 05
			// find all male people aged 45 or more
			List<string> malePeopleAger45OrOver = people
                                            .Where(x => x.Age >= 45 )
											.Where(x => x.Gender=='M')
											.Select(x => x.FirstName)
											.ToList();
			//malePeopleAger45OrOver.ForEach(x => Console.WriteLine(x));

			// Task 06
			// find all females whose name starts with V
			List<Person> femaleNameStartsWithV = people
										  .Where(x => x.Gender == 'F')
										  .Where(x => x.FirstName.StartsWith("V"))
										  .ToList();
			//femaleNameStartsWithV.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 07
			// find last female person older than 30 whose name starts with p
			Person lastFemalePersonOlderThan30AndNameStartsWithP = people
																  .LastOrDefault(x => x.Age > 30 && x.Gender == 'F' && x.FirstName.StartsWith("P"));
			//Console.WriteLine(lastFemalePersonOlderThan30AndNameStartsWithP.FirstName); =>Throws exception Null because there isn't a Person with the given requirements in the list



			// Task 08
			// find first male younger than 40
			Person firstMalePersonYoungerThan40 = people
												.FirstOrDefault(x => x.Gender == 'M' && x.Age < 40);
			// Console.WriteLine(firstMalePersonYoungerThan40.FirstName);


			// Task 09
			// print the names of the male persons that have firstName longer than lastName

			var namesOfMalesThatHaveALongerFirstNameThanLastName = people
																	  .Where(x => x.FirstName.Length > x.LastName.Length)
																	  .Select(x=>x.Gender=='M')
																	  .ToList();
			//namesOfMalesThatHaveALongerFirstNameThanLastName.ForEach(x => Console.WriteLine(x)); =>Returns false because there is no male person in the list that has a longer firstName than lastName. 

			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			List<string> lastNamesOfFemalesWithOddAges = people
													.Where(x => x.Gender == 'F')
													.Where(x => x.Age % 2 != 0)
													.Select(x => x.LastName)
													.ToList();
			//lastNamesOfFemalesWithOddAges.ForEach(x => Console.WriteLine(x));





			Console.ReadLine();
        }
    }
}
