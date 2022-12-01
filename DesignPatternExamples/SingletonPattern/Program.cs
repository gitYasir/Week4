using System;
using SingletonPattern;

namespace SingletonPattern;

public class Program
{
    //create new instane and assign to private class field _singleton
    private static Singleton _singleton = Singleton.Instance;

    public static void Main()
    {
        Console.WriteLine(_singleton.GetCount());
        //Output 0

        _singleton.Increment();
        // Increment counter by 1

        Console.WriteLine(_singleton.GetCount());
        //Output 1

        var singleton = Singleton.Instance;
        // Get instance and assign to variable singleton

        Console.WriteLine(singleton.GetCount());
        //Output 1

        _singleton.Increment();
        // Increment counter by 1

        Console.WriteLine(_singleton.GetCount());
        Console.WriteLine(singleton.GetCount());
        // Output 2 for both
    }

}
