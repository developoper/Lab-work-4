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

					// 1 способ

					Console.Write("1) ");
					string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					for (int i = 0; i < words.Length; i++)
					{
						string word = words[i];
						if (Char.IsUpper(word[0]) && Char.IsNumber(word[word.Length - 1]) && Char.IsNumber(word[word.Length - 2]))
						{
							Console.Write(words[i] + "; ");
						}
					}

					// 2 способ

					Console.Write("2) ");
					Regex regex = new Regex(@"\b[A-Z]\w+[0-9]{2}");
					MatchCollection words_1 = regex.Matches(text);
					if (words_1.Count > 0)
					{
						foreach (Match match in words_1)
						{
							Console.Write(match.Value + "; ");
						}
					}
					else
					{
						Console.Write("Совпадений не найдено");
					}
				}
				catch (FormatException exception)
				{
					error = 0;
					Console.WriteLine(exception + "\n ");
				}

				Console.ReadKey();
			}
		}
	}
}
