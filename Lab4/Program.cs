using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine("\t\t\t\t      THIS");
			Console.WriteLine("\t\t\t\t-----------------");
			Console.WriteLine("\t\t\t\t        IS");
			Console.WriteLine("\t\t\t\t-----------------");
			Console.WriteLine("\t\t\t\t       THE");
			Console.WriteLine("\t\t\t\t-----------------");
			Console.WriteLine("\t\t\t\t  !POWER TABLE!");

			bool Yes = true;
			string yes = "Y";
			string no = "N";

			while (Yes)
			{
				Console.WriteLine();
				Console.WriteLine("\t\t      Hello... friend. Please enter a number.");

				Console.WriteLine();
				string input = Console.ReadLine();

				int length = int.Parse(input);
				Console.WriteLine("\t\t       Number   \tSquared   \tCubed");
				for (int i = 1; i <= length; i++)
				{
					Console.WriteLine("\t\t       Number   \tSquared   \tCubed");
					Console.WriteLine($"\t\t       {i}\t\t{i * i}\t\t{i * i * i}");
				}
				Console.WriteLine("Would you like to check another number?: Y/N");

				string again = Console.ReadLine().ToUpper();


				if (again == yes)
				{
					Console.WriteLine("Lets use a different number");
					continue;
				}
				else if (again == no)
				{
					Console.WriteLine("Thanks... friend. have a nice day.");
					return;

				}
			}


		}
	}
}
