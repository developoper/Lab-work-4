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
					string[] array = new string[7];
					int num = 1;
					for (int i = 0; i < 7; i++)
					{
						Console.WriteLine("Введите предложение " + num);
						array[i] = Console.ReadLine();
						num++;
					}

					// 1 способ

					Console.Write("1) ");
					int minSpaceIndex = 0;
					for (int i = 0, minSpace = 100; i < 7; i++)
					{
						string text = array[i];
						for (int symbol = 0, space = 0; symbol < text.Length; symbol++)
						{
							if (text[symbol] == ' ')
							{
								space++;
							}
							else if (symbol == text.Length - 1)
							{
								if (space <= minSpace)
								{
									minSpace = space;
									minSpaceIndex = i;
								}
							}
							if (text[symbol] == '.' && text[symbol + 1] == 'c' && text[symbol + 2] == 'o' && text[symbol + 3] == 'm')
							{
								Console.Write(array[i] + "; ");
							}
						}
					}
					Console.WriteLine("Наименьшее число пробелов: " + array[minSpaceIndex]);

					// 2 способ

					Console.Write("2) ");
					int minSpaceIndex_1 = 0;
					for (int i = 0, minSpace_1 = 100; i < 7; i++)
					{
						for (int count = 0, maxSpaces = 0; count <= array[i].LastIndexOf(' ');)
						{
							count = array[i].IndexOfAny(new char[] { ' ' }, count) + 1;
							maxSpaces++;
							if (count >= array[i].LastIndexOf(' ') && maxSpaces <= minSpace_1)
							{
								minSpace_1 = maxSpaces;
								minSpaceIndex_1 = i;
							}
						}
						if (array[i].IndexOf(".com", StringComparison.CurrentCulture) >= 0)
						{
							Console.Write(array[i] + "; ");
						}
					}
					Console.WriteLine("Наименьшее число пробелов: " + array[minSpaceIndex_1]);
				}
				catch (FormatException exception)
				{
					error = 0;
					Console.WriteLine(exception + "\n ");
				}
			}

			Console.ReadKey();
		}
	}
}
