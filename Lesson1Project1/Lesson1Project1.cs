using System;

namespace Lesson1Project1
{
    class Lesson1Project1
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.WriteLine("Введите число: ");
            }
            while (Int32.TryParse(Console.ReadLine(), out n));

            int d = 0;
            int i = 2;

            while(i < n)
            {
                if (n % i == 0)
                    d++;

                i++;
            }

            if(d == 0)
                Console.WriteLine("число составное.");
            else
                Console.WriteLine("число простое.");

            Console.ReadKey();
        }

        
    }
}
