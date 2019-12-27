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
                    // Hello, my na+me Yan. I ho+pe this programm wo+rks done.
                    Console.Write("Введите предложение: ");
                    string text = Convert.ToString(Console.ReadLine());
                    Regex words = new Regex(@"(\b\w+[A-za-z]\+\w+[a-z]\b)");
                    MatchCollection matches = words.Matches(text);
                    foreach (Match match in matches)
					{
						string wordplus = @"(\b\w+[A-za-z]\+\w+[a-z]\b)";
						string replacement = "CONCAT";
						text = Regex.Replace(text, wordplus, replacement);
					}
					Console.WriteLine(text);
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