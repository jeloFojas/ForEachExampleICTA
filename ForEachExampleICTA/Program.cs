using System;

namespace ForEachExampleICTA
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/*Your task for this code is to:
			 *Able to search through the collection and
			 *if they found something it will return
			 *{name} is found on the list;
			 *if they did not found anything on the collection
			 *it will return "NOTHING IS FOUND"
			 *
			 *YOU NEED TO FIND THE BUG AND FIX IT.
			 *THE INITIAL CODE IS ALREADY GIVEN. 
			 *YOU NEED TO POLISH THIS CODE. 
			 */
			string[] names = {"Tongol", 
								"Morgado",
								"Ferolino",
								"Espiritu",
								"Curachea",
								"Panuncio",
								"De Vera",
								"Hilado",
								"Estrada"};

			Console.Write("Enter the name that you want to search: ");
			String nameSearched = Console.ReadLine();
			
			foreach (string name in names)
			{
				if (nameSearched == name) // searching
				{
					Console.WriteLine($"{name} is found on the list");
					break;
				}
				else
				{
					Console.WriteLine("NOTHING IS FOUND");
					break;
				}
				
			}


			Console.ReadLine();
		}
	}
}
