using System;

namespace LaboratoryWork.Utils
{
  public static class Base
  {
    public static int ReadInt32(string prompt = "")
    {
      Console.Write(prompt);
      int result;
      int.TryParse(Console.ReadLine(), out result);
      return result;
    }

    public static double ReadDouble(string prompt = "")
    {
      Console.Write(prompt);
      double result;
      double.TryParse(Console.ReadLine(), out result);
      return result;
    }
  }
}