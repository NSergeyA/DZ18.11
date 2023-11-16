using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LAB
{

    internal class ACipher : ICipher
    {
        public string Encode(string text)
        {
            char[] encodechar = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                encodechar[i] = (char)(text[i] + 1);
            }

            return new string(encodechar);
        }
        public string Decode(string text)
        {
            char[] decodechar = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                decodechar[i] = (char)(text[i] - 1);
            }

            return new string(decodechar);
        }
    }
}