using System;

namespace Samples.PassingByValue
{
	class MainClass
	{
		public static int Main()
		{
			int a = 3;
			int b = 6;
			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Values before swapping.");
			Print(a, b);
			Console.WriteLine("Swapping...");
			Swap(a, b);
			Console.WriteLine("Values after swapping.");
			Print(a, b);
			Console.WriteLine(Environment.NewLine);
			return 0;
		}

		static void Print(int number1, int number2)
		{
			Console.WriteLine("(a) = {0}", number1);
			Console.WriteLine("(b) = {0}", number2);
		}

		static void Swap(int number1, int number2)
		{
			int temp = number1;
			number1 = number2;
			number2 = temp;
		}
	}
}
