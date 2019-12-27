using System;

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
					string text = Convert.ToString(Console.ReadLine()).Trim('.');
					if (text[text.Length - 1] != '.')
					{
						text += ".";
					}

					// 1 способ

					Console.Write("1) ");
					int count = 1;
					for (int i = 0; i < text.Length; i++)
					{
						if (text[i] != '.' && text[i] != text.Length)
						{
							if (text[i] == '-')
							{
								Console.Write(text[i]);
							}
							else if (text[i] == ' ' & text[i + 1] == ' ')
							{
								Console.Write("");
							}
							else if (text[i] != ' ' & text[i + 1] == ' ' & text[i] != '.')
							{
								Console.Write($"{text[i]}({count})");
								count++;
							}
							else
							{
								Console.Write(text[i]);
							}
						}
						else
						{
							Console.Write($"({count}).");
						}
					}
					Console.WriteLine();

					// 2 способ

					Console.Write("2) ");
					for (int i = 0; i <= text.Length - 1; i++)
					{
						text = text.Replace("  ", " ");
					}
					string[] array = text.Split(new char[] { ' ' });
					int Count = 1;
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i] == '-'.ToString() || array[i] == ','.ToString())
						{
							Console.Write(array[i]);
							continue;
						}
							Console.Write($"{array[i]}({Count}) ");
							Count++;
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
