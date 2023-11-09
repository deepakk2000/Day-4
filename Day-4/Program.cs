using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Deepak";
            int age = 24;
            double height = 180.1;
            Console.WriteLine("--------------Part-1--------------");
            Console.WriteLine($"Name:{name}\nAge:{age}\nHeight:{height}");
            Console.WriteLine("--------------Part-2--------------");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Natural Even Number");
            int number = 1;
            int count = 1;
            while (count <= 10)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                    count++;
                }
                number++;
            }
            int number1 = 1;
            int count1 = 1;
            Console.WriteLine("Natural Odd Number");
            int numberr = 1;
            int countt = 1;
            do
            {
                if (numberr % 2 != 0)
                {
                    Console.WriteLine(numberr);
                    countt++;
                }
                numberr++;
            } while (countt <= 10);
            Console.WriteLine("--------------Part-3--------------");
            Console.WriteLine("--------------FibonacciSeries--------------");
            int n = 10;
            int a = 0;
            int b = 1;
            int c;
            for(int i = 0; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.WriteLine("--------------Part-4--------------");
            int[] numberArray = new int[] { 10, 20, 30, 40, 50 };
            int sum = 0;
            double average;
            foreach(int num in numberArray)
            {
                sum += num;
            }
            average=sum/numberArray.Length;
            Console.WriteLine($"Average:{average}\nSum:{sum}");
            Console.WriteLine("--------------Part-5--------------");
            Console.WriteLine("Enter your Exam Score ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine('A');
            }else if (score >= 80)
            {
                Console.WriteLine('B');
            }else if (score >= 70)
            {
                Console.WriteLine('C');
            }else if (score >= 60)
            {
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine('F');
            }

        }
    }
}
