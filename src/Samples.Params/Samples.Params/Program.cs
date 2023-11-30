using System;

namespace Samples.Params
{
	class MainClass
	{
		public static int Main(string[] args)
		{
			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Sum(7,23,4,8,2,12) = {0}", Sum(7, 23, 4, 8, 2, 12));
			Console.WriteLine("Sum(7,23,4,8) = {0}", Sum(7, 23, 4, 8));
			Console.WriteLine("ATGC,TGATCTTGGCCAT = ({0})", Assembly("ATGC", "TGATCTTGGCCAT"));
			Console.WriteLine("CATCAATG,CATTGATGGC,CAGCAT = ({0})", Assembly("CATCAATG", "CATTGATGGCC", "CAGCAT"));
			Console.WriteLine(Environment.NewLine);
			return 0;
		}

		static float Sum(params int[] data)
		{
			int sum = 0;
			for (int i = 0; i < data.Length; i++)
				sum += data[i];
			return sum;
		}

		static string Assembly(params string[] sequences)
		{
			string s = null;
			for (var i = 0; i < sequences.Length; i++)
				s += sequences[i];
			return s;
		}
	}
}
