using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace LaboratoryWork.Extensions
{
  public static class Enumerable
  {
    public static IEnumerable<T> Sorted<T>(this IEnumerable<T> sequence, IComparer<T> comparer)
    {
      if (sequence == null)
        throw new ArgumentNullException(nameof(sequence), "sequence can't be null");
      if (comparer == null)
        throw new ArgumentNullException(nameof(comparer), "comparer can't be null");
      
      T[] array = sequence.ToArray();

      for (var j = array.Length - 1; j > 0; j--)
        for (var i = 0; i < j; i++)
          if (comparer.Compare(array[i], array[j]) > 0)
          {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
          }
      
      foreach (var item in array)
        yield return item;
    }

    public static IEnumerable<T> Sorted<T>(this IEnumerable<T> sequence)
    {
      if (sequence == null)
        throw new ArgumentNullException(nameof(sequence), "sequence can't be null");
      
      foreach (var item in sequence.Sorted(Comparer<T>.Default))
        yield return item;
    }

    public static IEnumerable<T> SortedDescending<T>(this IEnumerable<T> sequence, IComparer<T> comparer)
    {
      if (sequence == null)
        throw new ArgumentNullException(nameof(sequence), "sequence can't be null");
      if (comparer == null)
        throw new ArgumentNullException(nameof(comparer), "comparer can't be null");
      
      T[] array = sequence.ToArray();

      for (var j = array.Length - 1; j > 0; j--)
        for (var i = 0; i < j; i++)
          if (comparer.Compare(array[i], array[j]) < 0)
          {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
          }
      
      foreach (var item in array)
        yield return item;
    }

    public static IEnumerable<T> SortedDescending<T>(this IEnumerable<T> sequence)
    {
      if (sequence == null)
        throw new ArgumentNullException(nameof(sequence), "sequence can't be null");
      
      foreach (var item in sequence.SortedDescending(Comparer<T>.Default))
        yield return item;
    }

    public static IEnumerable<T> Print<T>(this IEnumerable<T> sequence, string delimiter = "")
    {
      if (sequence == null)
        throw new ArgumentNullException(nameof(sequence), "sequence can't be null");
      
      IEnumerator<T> enumerator = sequence.GetEnumerator();
      if (enumerator.MoveNext())
      {
        Console.Write(enumerator.Current);
        yield return enumerator.Current;
      }
      
      while (enumerator.MoveNext())
      {
        Console.Write("{0}{1}", delimiter, enumerator.Current);
        yield return enumerator.Current;
      }
    }

    public static IEnumerable<T> PrintLine<T>(this IEnumerable<T> sequence, string delimiter = "")
    {
      if (sequence == null)
        throw new ArgumentNullException(nameof(sequence), "sequence can't be null");

      foreach (var item in sequence.Print(delimiter))
        yield return item;
      Console.WriteLine();
    }
  }
}
