using System;

namespace Task1Logic
{
  /// <summary>
  /// class implementes sorting by Decrease Max Abs Item Of ever Line of jagged array
  /// </summary>
  public class ComparerByDecreaseMaxAbsItemOfLine : IArrayComparer
  {
    public int Compare(int[] lhs, int[] rhs)
    {
      if (MaxAbsElementOfArray(lhs) < MaxAbsElementOfArray(rhs))
      {
        return 1;
      }

      if (MaxAbsElementOfArray(lhs) > MaxAbsElementOfArray(rhs))
      {
        return -1;
      }

      return 0;
    }

    private static long MaxAbsElementOfArray(int[] array)
    {
      long maxEl = 0;
      var tempArrayOfLong = new long[array.Length];

      for (int j = 0; j < array.Length; j++)
      {
        tempArrayOfLong[j] = array[j];
      }
      for (int i = 0; i < array.Length; i++)
      {
        if (maxEl < Math.Abs(tempArrayOfLong[i]))
        {
          maxEl = Math.Abs(tempArrayOfLong[i]);
        }
      }

      return maxEl;
    }
  }
}