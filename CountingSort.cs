using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Counting_Sort
{
    public class CountingSort
    {
        public static int[] CountingSortFunc(int[] array, int k)
        {
           
            int[] countArray = new int[k];

           
            for (int i = 0; i < array.Length; i++)
            {
                countArray[array[i]]++;
            }
                

           
            for (int i = 1; i < k; i++)
            {
                
                countArray[i] = countArray[i] + countArray[i - 1];
            }
                

          
            int[] resultArray = new int[array.Length];

            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                resultArray[countArray[array[i]] - 1] = array[i]; 
                countArray[array[i]] = countArray[array[i]] - 1;
            }

            return resultArray;
        }

        public static int[] CountingSortSimple(int[] array)
        {
            int[] tempArray = new int[10];

            for (int n = 0; n < array.Length; n++)
            {
                tempArray[array[n]]++;

            }

            int resultArrayPossition = 0;

            for (int k = 0; k < tempArray.Length; k++)
            {
                for (int i = 0;  i < tempArray[k];  i++)
                {
                    array[resultArrayPossition] = k;

                    resultArrayPossition++;
                }


            }
            return array;
        }
    }
}
