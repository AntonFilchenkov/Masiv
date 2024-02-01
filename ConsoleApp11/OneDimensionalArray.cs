using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    // Одномерный массив
    sealed class OneDimensionalArray : Array
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
        public override void FillRandom()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }
        }

        // Метод заполнения массива с клавиатуры
        public override void FillKeyboard()
        {
            Console.WriteLine("Ввод с клавиатуры:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Метод вывода массива на экран
        public override void Print()
        {
            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override void Middle()
        {
            Console.WriteLine("Среднее значение");
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
            Console.WriteLine("Если число меньше -100 и больше 100, то его удаляю");
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
            Console.WriteLine("Удаление повторения");
            int length = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        array[i] = int.MinValue;
                        length--;
                    }
                }
            }
            int[] newArray = new int[length];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] != int.MinValue)
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            array = new int[length];
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }
            Print();
        }
    }
}
