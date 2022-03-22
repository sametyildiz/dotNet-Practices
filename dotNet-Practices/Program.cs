using System;

namespace dotNet_Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getNumbersToSortedList(5);

            //new Distinct().distinctPrint(new int[] { 2, 5, 4, 7, 69, 78, 7, 7, 7 ,5,5,5});
            //Console.WriteLine();
            //new Distinct().distinctPrint(new int[] { 2, 5, 4, 7, 69, 78, 7, 7, 7 ,5,5,5},69);
            getNumbersDistinct(5, 100);
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

        static void getNumbersDistinct(int size, int limit)
        {   
            int[] tmp = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0}. sayı : ", i + 1);
                tmp[i] =Convert.ToInt32(Console.ReadLine());
            }
            new Distinct().distinctPrint(tmp, limit);

        }
    }
}
