using System;
using System.Reflection;

namespace Reflection
{
  class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Task 1: ");
      DemoTask1();
      Console.WriteLine("\n\n\n\nTask 2:");
      DemoTask2();
      Console.ReadLine();
    }

    static void DemoTask2()
    {
      var person = new Person
      {
        Name = "Bekzat",
        Surname = "Toleutai",
        Age = 16,
        Gender = true,
      };

      var PersonProperties = typeof(Person).GetProperties();

      foreach (var property in PersonProperties)
      {
        Console.WriteLine($"{property.Name}:{property.GetValue(person)}");
      }
    }

    static void DemoTask1()
    {
      var methodInfo = typeof(Console).GetMethods();

      foreach (var methodName in methodInfo)
      {
        Console.WriteLine(methodName);
      }
    }
  }
}
