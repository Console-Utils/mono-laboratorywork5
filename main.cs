using System;
using System.Linq;
using LaboratoryWork.Utils;
using LaboratoryWork.Extensions;

namespace LaboratoryWork
{
  internal static class MainClass
  {
    private static void Main()
    {
      double[] a = LaboratoryWork.Utils.Array.ReadDouble(LaboratoryWork.Utils.Base.ReadInt32("Please enter a array length value: "), "Please enter a[{0}] value: ").PrintLine(", ").ToArray();
      
      a.Sorted().PrintLine(", ").ToArray();
    }
  }
}
