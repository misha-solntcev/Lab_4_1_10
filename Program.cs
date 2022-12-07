using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*10. В заданном массиве поменять местами наибольший и наименьший элементы.*/

namespace Lab_4_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(50);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int max = array[0];
            int max_i = 0;
            int min = array[0];
            int min_i = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_i = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    min_i = i;
                }
            }
            Console.WriteLine($"max_i = {max_i}, max = {max}");
            Console.WriteLine($"min_i = {min_i}, min = {min}");

            (array[max_i], array[min_i]) = (array[min_i], array[max_i]);

            Console.WriteLine("Измененный массив:");
            foreach (var item in array)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
