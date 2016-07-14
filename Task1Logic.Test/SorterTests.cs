using System;
using NUnit.Framework;
using System.Collections;
using Task1Logic.Tests.Comparers;

namespace Task1Logic.Tests
{
  public class SorterTests
  {
    [Test, TestCaseSource(typeof(FactoryTestingJaggedArray),
      nameof(FactoryTestingJaggedArray.TestCases))]
    public void Comparers_SortedArray(
      IArrayComparer comparer,
      int[][] unsortedArray,
      int[][] expectedArray)
    {
      Sorter.Sort(unsortedArray, comparer);
      CollectionAssert.AreEqual(unsortedArray, expectedArray);
    }
  }

  public class FactoryTestingJaggedArray
  {
    public static IEnumerable TestCases
    {
      get
      {
        yield return new TestCaseData
        (new ComparerByIncreaseSumOfLineItems(),
        new[]
        {
          new[] {1, 3, 5, 7, 9},
          new[] {6, 6, 8},
          new[] { 2, 4, 6, 8, 1, 0 },
          new[] { 2, -4 }
        },
        new[]
        {
          new[] { 2, -4 },
          new[] {6, 6, 8},
          new[] { 2, 4, 6, 8, 1, 0 },
          new[] {1, 3, 5, 7, 9}
        });

        yield return new TestCaseData
        (new ComparerByIncreaseSumOfLineItems(),
        new[]
        {
          new[] {int.MinValue, 3, 5, 7},
          new[] {6, 6, 8, 0, int.MaxValue},
          new[] { 2, 4, int.MinValue, int.MinValue, 6, -8, 1, 0 },
          new[] { 2 }
        },
        new[]
        {
          new[] { 2, 4, int.MinValue, int.MinValue, 6, -8, 1, 0 },
          new[] {int.MinValue, 3, 5, 7},
          new[] { 2 },
          new[] {6, 6, 8, 0, int.MaxValue}
        });

        yield return new TestCaseData
        (new ComparerByDecreaseSumOfLineItems(),
        new[]
        {
          new[] {int.MinValue, 3, 5, 7},
          new[] {6, 6, 8, 0, int.MaxValue},
          new[] { 2, 4, int.MinValue, int.MinValue, 6, -8, 1, 0 },
          new[] { 2 }
        },
        new[]
        {
          new[] {6, 6, 8, 0, int.MaxValue},
          new[] { 2 },
          new[] {int.MinValue, 3, 5, 7},
          new[] { 2, 4, int.MinValue, int.MinValue, 6, -8, 1, 0 }
        });

        yield return new TestCaseData
        (new ComparerByDecreaseSumOfLineItems(),
        new[]
        {
          new[] {int.MaxValue, int.MinValue, 3, 5, 7},
          new[] {6, 6, 8, 0, int.MaxValue},
          new[] { 2, 4, int.MinValue, -8, 1, 0 },
          new[] { 2 }
        },
        new[]
        {
          new[] {6, 6, 8, 0, int.MaxValue},
          new[] {int.MaxValue, int.MinValue, 3, 5, 7},
          new[] { 2 },
          new[] { 2, 4, int.MinValue, -8, 1, 0 }
        });

        yield return new TestCaseData
        (new ComparerByDecreaseSumOfLineItems(),
        new[]
        {
          new[] {6, 6, 8, 0, int.MaxValue}
        },
        new[]
        {
          new[] {6, 6, 8, 0, int.MaxValue}
        });

        yield return new TestCaseData
        (new ComparerByIncreaseMaxAbsItemOfLine(),
        new[]
        {
          new[] {int.MaxValue, int.MinValue, 3, 5, 7},
          new[] {6, 6, 8, 0, 88},
          new[] { 2, 4, int.MaxValue, -8, 1, 0 },
          new[] { -93 }
        },
        new[]
        {
          new[] {6, 6, 8, 0, 88},
          new[] { -93 },
          new[] { 2, 4, int.MaxValue, -8, 1, 0 },
          new[] {int.MaxValue, int.MinValue, 3, 5, 7}
        });

        yield return new TestCaseData
        (new ComparerByIncreaseMaxAbsItemOfLine(),
        new[]
        {
          new[] {- int.MaxValue, int.MinValue, 3, 5, 7},
          new[] {6, 72, 8, 0, 88},
          new[] { 2, -8, -71, 0 },
          new[] { -93, int.MaxValue}
        },
        new[]
        {
          new[] { 2, -8, -71, 0 },
          new[] {6, 72, 8, 0, 88},
          new[] { -93, int.MaxValue},
          new[] {- int.MaxValue, int.MinValue, 3, 5, 7}
        });

        yield return new TestCaseData
        (new ComparerByDecreaseMaxAbsItemOfLine(),
        new[]
        {
          new[] {- int.MaxValue, int.MinValue, 3, 5, 7},
          new[] {6, 72, 8, 0, 88},
          new[] { 2, -8, -71, 0 },
          new[] { -93, int.MaxValue}
        },
        new[]
        {
          new[] {- int.MaxValue, int.MinValue, 3, 5, 7},
          new[] { -93, int.MaxValue},
          new[] {6, 72, 8, 0, 88},
          new[] { 2, -8, -71, 0 }
        });

        yield return new TestCaseData
        (new ComparerByDecreaseMaxAbsItemOfLine(),
        new[]
        { new[] {int.MinValue}},
        new[]
        { new[] {int.MinValue}});
      }

    }
  }
}


