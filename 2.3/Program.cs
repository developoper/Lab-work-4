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
                    string text = Convert.ToString(Console.ReadLine());

                }
                catch (FormatException expection)
                {
                    error = 0;
                    Console.WriteLine(expection.Message + "\n");
                }
            }
		}
	}
}
