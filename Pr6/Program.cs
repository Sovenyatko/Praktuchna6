using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        string[] lines = File.ReadAllLines("input.txt");
        sortedLines = lines.OrderBy(line => line).ToArray
        string[] ();

        File.WriteAllLines("output.txt", sortedLines);
    }
}

