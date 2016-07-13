using System;

namespace Task1Logic
{
  public class Sorter
  {
    /// <summary>
    /// class Sorter have one public method Sort and private method-helper Swap
    /// </summary>
    /// <param name="array">jagged unsorted array</param>
    /// <param name="comparer">interface reference</param>
    /// <returns></returns>
    public static int[][] Sort (int[][] array, IArrayComparer comparer)
    {
      if (array.Length == 1 || array.Length == 1)
      {
        return array;
      }

      for (int n = array.Length - 1; n > 0; n--)
      {
        for (int i = 0; i < n; i++)
        {
          var compareResult = comparer.Compare(array[i], array[i + 1]);

          if (compareResult > 0)
          {
            Swap(ref array[i], ref array[i + 1]);
          }
        }
      }

      return array;
    }

    private static void Swap(ref int[] lhs, ref int[] rhs)
    {
      int[] glass = lhs;
      lhs = rhs;
      rhs = glass;
    }
  }
}
