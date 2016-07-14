using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace ConsoleUI
{
  class Program
  {
    public delegate int CompareDelegateTest(int[] ar1, int[] ar2);

    static void Main(string[] args)
    {
      var unsorted = new[]
        {
          new[] { 2, 4, 6, 8, 1, 0 },
          new[] { 1, -1, 3},
          new[] { 2 },
          new[] { -3, -5}
        };


      //Func<int[], int[], int> myDel1 = SumCompare;
      //CompareDelegateTest compareDelegateTest = SumCompare;

      var del = new Sorter.ComparerDelegate(SumCompare);
     // del += SumCompare;


      ShowArray(unsorted);
      var sorted = Sorter.Sort(unsorted, del);


      ShowArray(sorted);
    }

    static int SumCompare(int[] lhs, int[] rhs)
    {
      var sumLhs = SumOfArrayElements(lhs);
      var sumRhs = SumOfArrayElements(rhs);

      if (sumLhs > sumRhs)
      {
        return 1;
      }

      if (sumRhs > sumLhs)
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

    static void ShowArray(int[][] array)
    {
      Console.WriteLine();
      Console.WriteLine();
      for (var i = 0; i < array.Length; i++)
      {
        for(var j = 0; j < array[i].Length; j++)
        {
          Console.Write("[{0}]", array[i][j]);
        }
        Console.WriteLine();
      }
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
