using System;
using System.Globalization;

namespace LaboratoryWork.Utils
{
  public static class Array
  {
    public static double[] ReadDouble(int count, string prompt = "")
    {
      if (count < 0)
        throw new ArgumentOutOfRangeException(nameof(count), "array length can't be negative");
      
      double[] result = new double[count];
      for (var i = 0; i < count; i++)
        result[i] = Base.ReadDouble(string.Format(CultureInfo.CurrentCulture, prompt, i));
      return result;
    }
  }
}
