using System;
using System.Runtime.InteropServices;

class Program
{
    // Determine the native library name based on the current platform
    private const string LibName = "quickmath";

    [DllImport(LibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int add(int a, int b);

    [DllImport(LibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int subtract(int a, int b);

    [DllImport(LibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int multiply(int a, int b);

    static void Main()
    {
        Console.WriteLine($"3 + 4 = {add(3, 4)}");
        Console.WriteLine($"10 - 6 = {subtract(10, 6)}");
        Console.WriteLine($"5 * 7 = {multiply(5, 7)}");
    }
}
