using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaRK_02._03._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("List:");
            List<int> numbers=Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine($"Broq na elementite e: {numbers.Count}");
            Console.Write($"Masiv 1:");
            int[] array1=Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArray1ToList(numbers,array1);
            Console.Write($"Masiv 2:");
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArray2ToList(numbers,array2);
            byte num=byte.Parse(Console.ReadLine());
            NumInListIs(numbers,num);
        }

        private static void AddArray2ToList(List<int> numbers, int[] array2)
        {
            numbers.InsertRange(3,array2);
            numbers.Sort();
            Console.WriteLine(string.Join("*", numbers));
        }

        private static void NumInListIs(List<int> numbers, byte num)
        {
            if (numbers.Contains(num))
            {
                Console.WriteLine($"Number {num} is on {numbers.IndexOf(num)}");
            }
        }

        private static void AddArray1ToList(List<int> numbers, int[] array)
        {
           numbers.AddRange(array);
            numbers.Sort();
            Console.WriteLine(string.Join("*",numbers));
        }
    }
}
