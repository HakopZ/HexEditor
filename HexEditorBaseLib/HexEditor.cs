using System;
using System.IO;
using System.Linq;

namespace HexEditorBaseLib
{
    public class HexEditor
    {
        //Byte, Hex, Decimal, Char, Binaru
        public HexEditor()
        {}
        public byte[] GetPathBytes(string path)
        {
            return File.ReadAllBytes(path);
        }
        public string[] ConverToHex(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Split('-');
        }
        public int[] GetDecimal(byte[] bytes) => bytes.Select(x => (int)x).ToArray();
        public string[] GetBinary(byte[] bytes) => bytes.Select(x => Convert.ToString()
        public string[] GetLettersFromHex(string[] hex)
        {
            return BitConverter.;
        }
    }
}
