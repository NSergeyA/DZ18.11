using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class BCipher : ICipher
    {
        public string Encode(string text)
        {
            char[] encodechar = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    encodechar[i] = (char)('я' - (text[i] - 'а'));
                }
                else if (char.IsUpper(text[i]))
                {
                    encodechar[i] = (char)('Я' - (text[i] - 'А'));
                }
            }

            return new string(encodechar);
        }

        public string Decode(string text)
        {
            return Encode(text);
        }
    }
}

