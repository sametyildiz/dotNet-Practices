using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_Practices
{
    internal class Sorter
    {
        public int[] addBySorted(int num, int[] list)
        {
            int[] returnList = new int[list.Length + 1];

            int i = findReplace(num, list);
            //while (i < list.Length && num >= list[i])//brute force
            //{
            //    returnList[i] = list[i];
            //    i++;
            //}
            Array.Copy(list, 0, returnList, 0, i);

            returnList[i] = num;
            //while (i < list.Length)
            //{
            //    returnList[i + 1] = list[i++];
            //}
            Array.Copy(list, i, returnList, i + 1, list.Length - i);

            return returnList;
        }

        private int findReplace(int num, int[] list)
        {
            if (list.Length == 0)
                return 0;
            int index = 0;
            int start = 0;
            int end = list.Length;
            while (end != start)
            {
                index = (start + end) / 2;

                if (num > list[index])
                    start = index + 1;
                else if (num < list[index])
                    end = index;
                else
                    return index;
            }
            return num > list[index] ? index + 1 : index;

        }
        public void printArray(int[] array)
        {
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
