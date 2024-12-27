using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        string X = "1|2|3|";
        string [] A = X.Split(',');
        Console.WriteLine(A[0]);
        Console.WriteLine(A[1]);
        Console.WriteLine(A[2]);
    }
}
        