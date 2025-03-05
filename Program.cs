using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8
{
    class Program
    {
        static void Main(string[] args)
        {
			// Объявление и инициализация массива
			int[] arr = new int[] { 1, 8, 6, 7, 5, 9 };

			// Сортировать массив по возрастанию
			Array.Sort(arr);
			Console.WriteLine("По возрастанию: ");
			foreach (int value in arr)
			{
				Console.Write(value + " ");
			}
		}
    }
}
