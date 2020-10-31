using HexEditorBaseLib;
using System;
using System.Linq;

namespace ConsoleHexEditiorGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            HexEditor editor = new HexEditor();
            var bytes = editor.GetPathBytes(@"C:\Users\hakop\OneDrive\Documents\Visual Studio 2019\Projects\HelloWorld\HelloWorld\Program.fs");
            var hex = editor.ConvertToHex(bytes);
            var chars = editor.GetLettersFromHex(hex);

            int length = hex.Length;
            for (int i = 0; i < Math.Ceiling((double)(length) / 16); i++)
            {
                var listH = hex.Take(16).ToList();
                var listC = chars.Take(16).ToList();
                hex = hex.Skip(16).ToArray();
                chars = chars.Skip(16).ToArray();
                foreach(var h in listH)
                {
                    Console.Write($"{h} ");
                }
                Console.SetCursorPosition(60, Console.CursorTop);
                foreach(var c in listC)
                {
                    if (!char.IsControl(c))
                        Console.Write($"{c} ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
           


        }
    }
}
