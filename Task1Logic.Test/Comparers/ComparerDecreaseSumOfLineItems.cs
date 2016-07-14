using System;

namespace Task1Logic.Tests.Comparers
{
  /// <summary>
  /// class implementes sorting by Decrease Sum Of Line Items of jagged array
  /// </summary>
  public class ComparerByDecreaseSumOfLineItems : IArrayComparer
  {
    public int Compare(int[] lhs, int[] rhs)
    {
      var sumX = SumOfArrayElements(lhs);
      var sumY = SumOfArrayElements(rhs);

      if (sumX < sumY)
      {
        return 1;
      }

      if (sumY < sumX)
      {
        return -1;
      }

      return 0;
    }

    private static long SumOfArrayElements(int[] array)
    {
      long sum = 0;
      for (int i = 0; i < array.Length; i++)
      {
        sum += array[i];
      }

      return sum;
    }
  }
}
