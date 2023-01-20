using System;

class Program {
  public static void Main (string[] args) {
     int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
    int MaxNum(int[] array){
      int max = array[0];
      for(int i=0; i < array.Length; i++)
    {
      if (array[i]>max)
      {
       max = array[i];
      }
    }
      return max;
      }

    int MinNum(int[] array){
      int min = array[0];
      for(int i=0; i < array.Length; i++)
    {
      if (array[i]<min)
      {
       min = array[i];
      }
    }
      return min;
      }

    int[] array = CreateRandomArray (5,0,100);

    int max = MaxNum(array);
    int min = MinNum(array);

ShowArray(array);
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max-min);
  }
}