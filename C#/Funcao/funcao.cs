using System;

public class Class1
{
	public Class1()
	{
        // Funções
        float MilesToKm(float miles)
        {
            float result = miles * 1.6f;
            return result;
        }

        void PrintWithPrefix(string theStr)
        {
            Console.WriteLine($"::> {theStr}");
        }

        MilesToKm(10.0f);
        PrintWithPrefix("Test string");

        // Tuplas 
        (int a, int b) tup1 == (5, 10);
        var tup2 = ("soem text", 10.5f);

        tup1.a = 20;
        tup2.Item1 = "other text";

        Console.WriteLine($"Tup1: {tup1.a}, {tup1.b}");
        Console.WriteLine($"Tup2: {tup2.a}, {tup2.b}");
    }
}
