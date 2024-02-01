using System;
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            Array[] arrays = new Array[3];

            arrays[0] = new OneDimensionalArray(4, true);
            //arrays[1] = new TwoDimensionalArray(4, 4, true);
            //arrays[2] = new StepArray(new int[] { 1, 2, 3 }, true);


            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] == null)
                    return;

                arrays[i].Print();
                arrays[i].Middle();
                if (arrays[i] is OneDimensionalArray)
                {
                    OneDimensionalArray temp = (OneDimensionalArray)arrays[i];
                    temp.Minimal();
                    temp.Delite();
                }
                else if (arrays[i] is TwoDimensionalArray)
                {
                    TwoDimensionalArray temp = (TwoDimensionalArray)arrays[i];
                    temp.Middle();
                    temp.Reverse();
                }
                else if (arrays[i] is StepArray)
                {
                    StepArray temp = (StepArray)arrays[i];
                    temp.Middle();
                    temp.MidleOne();
                    temp.ReverseIndex();
                }
            }

            Console.ReadLine();
        }
    }
}

