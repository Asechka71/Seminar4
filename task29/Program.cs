/* 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите массив через запятую ");
int[] collectionPrint = Array.ConvertAll<string,int>
(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32 (elem);});

void PrintArray(int[] collectionPrint)
{
    int count = collectionPrint.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
      Console.Write(collectionPrint[position]+ ", ");
      position++;
    }
    Console.Write(collectionPrint[position] +"]");
}
PrintArray(collectionPrint);
