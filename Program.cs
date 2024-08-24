
using Counting_Sort;

int[] exmArray = new int[] { 0, 2, 3, 4, 2, 5, 4, 5, 6, 1, 2, 6, 7, 4, 6, 7, 8, 9, 5, 7, 8, 3, 2, 4, 5, 6, 1 };
int range = 10;
int[] result = CountingSort.CountingSortFunc(exmArray, range);

//for(int i=0; i<= result.Length; i++)
//{
//    Console.WriteLine(result[i]);
//}


int[] resultSimple = CountingSort.CountingSortSimple(exmArray);
for (int i = 0; i <= resultSimple.Length; i++)
{
    Console.WriteLine(resultSimple[i]);
}