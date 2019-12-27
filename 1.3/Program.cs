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
					string text = Convert.ToString(Console.ReadLine()).Trim('.').ToLower();

					// 1 способ

					Console.Write("1) ");
					string[] array = new string[text.Length];
					char[] trigger = { ' ' };
					int count = 0;
					for (int i = 0; i < text.Length; i = text.IndexOfAny(trigger, i) + 1)
					{
						if (count == 0)
						{
							text += " ";
						}
						for (int j = i; j != text.IndexOfAny(trigger, i) && j < text.Length; j++)
						{
							array[count] += text[j];
						}
						count++;
					}
					Array.Resize(ref array, count);
					Array.Reverse(array);
					foreach (string word in array)
					{
						Console.Write(word + " ");
					}

					// 2 способ

					Console.Write("\n2) ");
					string[] array_1 = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
					Array.Reverse(array_1);
					for (int i = 0; i < array_1.Length; i++)
					{
						if (i == array_1.Length - 1)
						{
							Console.Write(array_1[i] + ".");
						}
						else
						{
							Console.Write(array_1[i] + " ");
						}
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
