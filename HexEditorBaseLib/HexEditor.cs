using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace HexEditorBaseLib
{
    public class HexEditor
    {
        //Byte, Hex, Decimal, Char, Binaru
        public HexEditor()
        { }
        public byte[] GetPathBytes(string path)
        {
            return File.ReadAllBytes(path);
        }
        public string[] ConvertToHex(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Split('-');
        }
        public int[] GetDecimal(byte[] bytes) => bytes.Select(x => (int)x).ToArray();
        public string[] GetBinary(byte[] bytes) => bytes.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
        public char[] GetLettersFromHex(string[] hex)
        {
            List<char> chars = new List<char>();
            foreach (var h in hex)
            {
                int num = int.Parse(h, NumberStyles.AllowHexSpecifier);
                char cnum = (char)num;
                chars.Add(cnum);
            }
            return chars.ToArray();
        }
        public byte[] HexToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
