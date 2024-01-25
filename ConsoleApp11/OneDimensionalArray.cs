using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    // Одномерный массив
    class OneDimensionalArray
    {
        private int[] array;
        public int[] Array { get => array; set => array = value; }

        // true - заполнение с клавиатуры,
        // false - заполнение случайными
        public OneDimensionalArray(int length, bool fillKeyboard = false)
        {
            array = new int[length];

            if (fillKeyboard == true)
                FillKeyboard();
            else FillRandom();
        }

        // Метод заполнения массива случайными числами
        public void FillRandom()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }
        }

        // Метод заполнения массива с клавиатуры
        public void FillKeyboard()
        {
            Console.WriteLine("Ввод с клавиатуры:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Метод вывода массива на экран
        public void Print()
        {
            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public void Middle()
        {
            int q = 0;
            foreach (int i in array)
            {
                q += i;
            }
            q = q / array.Length;
            Console.WriteLine(q);

        }
        public void Minimal()
        {
            int[] ma = new int[array.Length];
            int r = 0;
            foreach (int i in array)
            {
                if ((i < 100) && (i > -100))
                {
                    ma[r] = i;
                    r++;
                }
                else
                {
                    ma[r] = 0;
                    r++;
                }
            }
            for (int i = 0; i != ma.Length; i++)
            {
                if (ma[i] != 0)
                {
                    Console.WriteLine(ma[i]);
                }
            }

        }
        public void Delite()
        {
            int[] x = new int[array.Length];
            int r = 0;
            for (int i = 0; i != array.Length; i++)
            {
                int c = array[i];
                for (int j = 0; j != array.Length; j++)
                {
                    if ((i != j) && (c == array[j]))
                    {
                        array[j] = 0;
                    }
                    x[r] = c;
                }
                r++;
            }
            for (int a = 0; a != x.Length; a++)
            {
                if (x[a] != 0)
                {
                    Console.Write(x[a] + " ");
                }
            }


        }
    }
}
