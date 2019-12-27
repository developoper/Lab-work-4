using System;
using System.Text.RegularExpressions;

namespace Application
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int error = 0;
			while (error == 0)
			{
				try
				{
					error = 1;
					Console.Write("Введите предложение: ");
					string text = Convert.ToString(Console.ReadLine());
					Regex numbers = new Regex(@"-?\d+");
					MatchCollection nums = numbers.Matches(text);
					foreach (Match match in nums)
					{
						int num = int.Parse(match.Value);
						Console.Write(num + " ");
					}
				}
				catch (FormatException exception)
				{
					error = 0;
					Console.WriteLine(exception + "\n");
				}

				Console.ReadKey();
			}
		}
	}
}
