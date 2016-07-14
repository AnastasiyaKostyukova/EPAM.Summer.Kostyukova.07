using System;

namespace Task1Logic
{
  /// <summary>
  /// class have 2 overloaded methods Sort
  /// </summary>
  public class Sorter
  {
    /// <summary>
    /// delegate
    /// </summary>
    /// <param name="a">the first input parameter int[] array</param>
    /// <param name="b">the second input parameter int[] array</param>
    /// <returns></returns>
    public delegate int ComparerDelegate(int[] a, int[] b);

    public static int[][] Sort(int[][] array, ComparerDelegate comparerDelegate)
    {
      if (array.Length == 1 || array.Length == 1)
      {
        return array;
      }

      for (int n = array.Length - 1; n > 0; n--)
      {
        for (int i = 0; i < n; i++)
        {
          var compareResult = comparerDelegate(array[i], array[i + 1]);

          if (compareResult > 0)
          {
            Swap(ref array[i], ref array[i + 1]);
          }
        }
      }

      return array;
    }


    /// <summary>
    /// method Sort sorts jagged array
    /// </summary>
    /// <param name="array">jagged unsorted array</param>
    /// <param name="comparer">interface reference</param>
    /// <returns>sorted array</returns>
    public static int[][] Sort (int[][] array, IArrayComparer comparer)
    {
      return Sort(array, new ComparerDelegate(comparer.Compare));      
    }

    private static void Swap(ref int[] lhs, ref int[] rhs)
    {
      int[] glass = lhs;
      lhs = rhs;
      rhs = glass;
    }


  }
}
