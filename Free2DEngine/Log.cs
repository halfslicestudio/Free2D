using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Log
{
    public static void Normal(string msg)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[LOG][Normal]: " + msg);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void Info(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("[LOG][Info]: " + msg);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void Warning(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[LOG][Warning]: " + msg);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void Error(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[LOG][Error]: " + msg);
        Console.ForegroundColor = ConsoleColor.White;
    }

}
