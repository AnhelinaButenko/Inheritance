using System;

namespace Itdvn
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterColor printerColor = new PrinterColor(ConsoleColor.DarkRed);
            printerColor.Print("Hello World");

            BasePrinter printerColorUp = printerColor;
            printerColorUp.Print("Hello World");

            PrinterColor printerColor1 = new PrinterColor(ConsoleColor.Blue);
            printerColor1.Print("Hello World");
        }
    }
}
