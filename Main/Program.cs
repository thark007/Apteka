using System;

namespace Main
{
	partial class Program
	{
		static void Main(string[] args)
		{

			string command = "";

			do
			{
				Console.WriteLine("wpisz polecenie");
				command = Console.ReadLine().ToLower();

			if (command == "add")
			{ }
			if (command == "edit")
			{ }
			if (command == "delete")
			{ }
			if (command == "show")
			{ }
			if (command == "exit")
			{
			break;
			}
			} while (true);
		}
	}
}
