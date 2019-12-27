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
                    // 192.1.1.178 is my Ipv4
                    Console.Write("Введите предложение: ");
                    string text = Console.ReadLine();
                    Regex address = new Regex(@"(\b\d{3}.\d{1}.\d{1}.\d{3}\b)");
                    MatchCollection matches = address.Matches(text);
                    foreach (Match match in matches)
                    {
                        Console.WriteLine(match.Value);
                    }
                }
                catch (FormatException exception)
                {
                    error = 0;
                    Console.WriteLine(exception.Message + "\n");
                }
				Console.ReadKey();
			}
		}
	}
}
