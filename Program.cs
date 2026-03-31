using System;
namespace Program
{
	class Code
	{
		static void Main(string[] args)
		{
			// Math Class In C#

			// #1 Maximum Function
			int maximum = Math.Max(34, 21);
			double maximum2 = Math.Max(21.76, 21.77);
			Console.WriteLine(maximum);
			Console.WriteLine(maximum2);

			// #2 Minimum Function
			int minimum = Math.Min(34, 21);
			double minimum2 = Math.Min(21.76, 21.77);
			Console.WriteLine(minimum);
			Console.WriteLine(minimum2);

			// #3 Square Root Function
			double square_root = Math.Sqrt(100);
			double square_root2 = Math.Sqrt(91);
			Console.WriteLine(square_root);
			Console.WriteLine(square_root2);

			// #4 Absolute Function
			int absolute = Math.Abs(-29);
			int absolute2 = Math.Abs(45);
			Console.WriteLine(absolute);
			Console.WriteLine(absolute2);

			// #5 Round Function
			double round = Math.Round(999.99);
			double round2 = Math.Round(-32.10);
			Console.WriteLine(round);
			Console.WriteLine(round2);

			// #6 Power Function
			double Power = Math.Pow(2, 2);
			double Power2 = Math.Pow(35.53, 3.1);
			Console.WriteLine(Power);
			Console.WriteLine(Power2);

			// There Are 70+ Functions.
		}
	}
}
