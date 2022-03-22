using System;

namespace dotNet_Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getNumbersToSortedList(5);
        }
        static void getNumbersToSortedList(int size)
        {
            Sorter sorter = new Sorter();
            int[] tmp = new int[] { };
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0}. sayı : ", i + 1);
                tmp = sorter.addBySorted(Convert.ToInt32(Console.ReadLine()), tmp);
                Console.Write("Dizi : ");
                sorter.printArray(tmp);
            }
        }
    }
}
