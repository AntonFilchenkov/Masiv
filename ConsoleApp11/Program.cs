using System;
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*OneDimensionalArray temp = 
                new OneDimensionalArray(4, true);
            temp.Print();*/

            TwoDimensionalArray temp2 =
                new TwoDimensionalArray(3, 2, true);

            /* StepArray stepArray =
                 new StepArray(new int[] { 1, 2, 3 }, false);
             stepArray.Print();*/
            temp2.Print();
            temp2.Middle();
            
        }
    }


   

    // Двумерный массив
    class TwoDimensionalArray
    {
        private int[,] array;
        public int[,] Array { get => array; set => array = value; }
        public TwoDimensionalArray(int columns, int rows, bool fillKeyboard = false)
        {
            array = new int[rows, columns];

            if (fillKeyboard == true)
            {
                FillKeyboard();
            }
            else FillRandom();
        }

        // Метод заполнения массива случайными числами
        public void FillRandom()
        {
            Random random = new Random();
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    array[x, y] = random.Next(0, 10);
                }
            }
        }

        // Метод заполнения массива с клавиатуры
        public void FillKeyboard()
        {
            Console.WriteLine("Ввод с клавиатуры:");

            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write($"[{x}, {y}] = ");
                    array[x, y] = int.Parse(Console.ReadLine());
                }
            }

        }

        // Метод вывода массива на экран
        public void Print()
        {
            Console.WriteLine("Вывод массива:");

            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write(array[x, y] + " ");
                }
                Console.WriteLine(" ");
            }

        }
        public void Middle()
        {
            int r = 0;
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    r += array[x, y];
                }
            }
            int q = array.GetLength(0) * array.GetLength(1);
            Console.WriteLine(r / q);
        }
        public void Reverse()
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    r += array[x, y];
                }
            }
        }
    }

    // Ступенчатый массив
    class StepArray
    {
        private int[][] array;

        public int[][] Array { get => array; set => array = value; }
        public StepArray(int[] columns, bool fillKeyboard = false)
        {
            array = new int[columns.Length][];

            for (int i = 0; i < columns.Length; i++)
            {
                array[i] = new int[columns[i]];
            }

            if (fillKeyboard == true)
            {
                FillKeyboard();
            }
            else FillRandom();
        }

        // Метод заполнения массива случайными числами
        public void FillRandom()
        {
            Random random = new Random();
            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    array[x][y] = random.Next(0, 10);
                }
            }
        }

        // Метод заполнения массива с клавиатуры
        public void FillKeyboard()
        {
            Console.WriteLine("Ввод с клавиатуры:");

            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    Console.Write($"[{x}][{y}] = ");
                    array[x][y] = int.Parse(Console.ReadLine());
                }
            }

        }

        // Метод вывода массива на экран
        public void Print()
        {
            Console.WriteLine("Вывод массива:");

            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array[x].Length; y++)
                {
                    Console.Write(array[x][y] + " ");
                }
                Console.WriteLine(" ");
            }

        }
    }


}

