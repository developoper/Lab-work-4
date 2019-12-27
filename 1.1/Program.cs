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
                    string text = Convert.ToString(Console.ReadLine().Trim('.').ToLower());

					// 1 способ

					Console.Write("1) ");
					for (int i = 0; i < text.Length; i++)
					{
						int check = 0;
						for (int j = 0; j < text.Length; j++)
						{
							if (i == j)
							{
								continue;
							}
							if (text[i] == text[j])
							{
								check++;
							}
						}
						if (check == 0)
						{
							Console.Write(text[i] + "; ");
						}
					}
					Console.WriteLine();

					// 2 способ

					Console.Write("2) ");
					string Text = string.Empty;
					for (int i = 0; i < text.Length; i++)
					{
						if (text.IndexOf(text[i]) == text.LastIndexOf(text[i]))
						{
							Text += text[i];
						}
						else
						{
							continue;
						}
					}
					foreach (char i in Text)
					{
						Console.Write(i + "; ");
					}
					Console.WriteLine();
				}
				catch(FormatException exception)
				{
					error = 0;
					Console.WriteLine(exception + "\n ");
				}

				Console.ReadKey();
			}
		}
	}
}
