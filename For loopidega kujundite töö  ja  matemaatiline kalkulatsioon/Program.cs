using System;

namespace For_loopidega_kujundite_töö_ja_matemaatiline_kalkulatsioon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali");
            Console.WriteLine("1. Joonista ring");
            Console.WriteLine("2. Matemaatiline kalkulatsioon Korrutus tabel");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Ring");
                Console.WriteLine("Sisesta ringi suurus");

                int size = Convert.ToInt32(Console.ReadLine());
                for (int y = size; y >= -size; y--)
                {
                    for (int x = -size; x <= size; x++)
                    {
                        if (x * x + y * y <= size * size)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Matemaatiline kalkulatsioon Korrutus tabel");
                Console.WriteLine("------------------------------------------");

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("\n|");
                    for (int j = 1; j <= 10; j++)

                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Vale valik");
            }
            Console.ReadLine();
        }
    }
}