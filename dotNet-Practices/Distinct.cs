using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_Practices
{
    internal class Distinct 
    {

        internal void distinctPrint(int[] list , int limit)
        {
            bool[] isUsedList = new bool[list.Length];

            for (int i = 0; i < list.Length; i++)
            {   
                if (isUsedList[i])
                    continue;
                isUsedList = useIt(isUsedList, list, i);
                Console.Write(list[i] + " ");
                if (list[i] == limit)
                    break;
            }

        }
        internal void distinctPrint(int[] list)
        {   bool[] isUsedList = new bool[list.Length];

            for(int i = 0; i < list.Length; i++)
            {
                if (isUsedList[i])
                    continue;
                isUsedList = useIt(isUsedList, list, i);
                Console.Write(list[i] + " ");
            }

        }
        private bool[]  useIt(bool[] isUsedList, int[] list, int index)
        {
            isUsedList[index] = true;
            for(int i = index + 1; i < list.Length ; i++)
            {
                if(list[index] == list[i])
                {
                    isUsedList[i] = true;
                }
            }

            return isUsedList;
        }
        

    }
}
