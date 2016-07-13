using System;

namespace Task1Logic
{
  /// <summary>
  /// class implementes sorting by Increase Sum of Line Items of jagged array
  /// </summary>
  public class ComparerByIncreaseSumOfLineItems : IArrayComparer
  {
    public int Compare(int[] lhs, int[] rhs)
    {
      var sumLhs = SumOfArrayElements(lhs);
      var sumRhs = SumOfArrayElements(rhs);

      if (sumLhs > sumRhs)
      {
        return 1;
      }

      if(sumRhs > sumLhs)
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
