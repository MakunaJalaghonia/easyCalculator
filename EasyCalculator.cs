using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{

			int num1, num2;
			string symbol;

			Console.WriteLine("daweret pirveli ritskhvi: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("daweret matematikuri operacia: ");
			symbol = Console.ReadLine();
			Console.WriteLine("daweret meore ritskhvi: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			switch (symbol)

			{
				case "+": Console.WriteLine("pasuxi aris : " + (num1 + num2)); break;
				case "-": Console.WriteLine("pasuxi aris : " + (num1 - num2)); break;
				case "/": Console.WriteLine("pasuxi aris : " + num1 / num2); break;
				case "*": Console.WriteLine("pasuxi aris : " + num1 * num2); break;
				default: Console.WriteLine("daweret swori matematikuri operacia"); break;

			}



			//if (symbol == "+")

			//{
				//Console.WriteLine("pasuxi aris: " + (num1 + num2));
			//}
			//else if (symbol == "-")
			//{
				//Console.WriteLine("pasuxi aris: " + (num1 - num2));
			//}
			//else if (symbol == "/")
			//{
				//Console.WriteLine("pasuxi aris: " + num1 / num2);
			//}
			//else if (symbol == "*")
			//{
				//Console.WriteLine("pasuxi aris: " + num1 * num2);
			//}

			//else

			//{
				//Console.WriteLine("daweret swori matematikuri operacia");

			//}







               




		

