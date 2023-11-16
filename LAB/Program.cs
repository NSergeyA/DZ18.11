using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1");
            string text = "Привет всем";
            ICipher aCipher = new ACipher();
            string encodedStringA = aCipher.Encode(text);
            string decodedStringA = aCipher.Decode(encodedStringA);

            ICipher bCipher = new BCipher();
            string encodedStringB = bCipher.Encode(text);
            string decodedStringB = bCipher.Decode(encodedStringB);

            Console.WriteLine("ACipher:");
            Console.WriteLine("Зашифрованный текст: " + encodedStringA);
            Console.WriteLine("Расшифрованный текст: " + decodedStringA);

            Console.WriteLine();

            Console.WriteLine("BCipher:");
            Console.WriteLine("Зашифрованный текст: " + encodedStringB);
            Console.WriteLine("Расшифрованный текст: " + decodedStringB);
            Console.WriteLine("Для продолжения нажмите любую кнопку.....");
            Console.ReadKey();


            Console.WriteLine("Домашнее задание 10.1");
            Point point = new Point(25, 30, "Зелёный", false);
            point.Display();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
