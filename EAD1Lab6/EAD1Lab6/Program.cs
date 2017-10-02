using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab6
{
    delegate string CipherDelegate(string message);
    class Program
    {

        public string caesarCipher(string message)
        {
            char[] buffer = message.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                // Letter.
                char letter = buffer[i];
                // Add shift to all.
                letter = (char)(letter + 1);
                // Subtract 26 on overflow.
                // Add 26 on underflow.
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                // Store.
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        public string reverseCipher(string message)
        {
            char[] buffer = message.ToCharArray();
            char[] newBuffer = new char[buffer.Length];
            int count = 0;

            for (int i = buffer.Length; i > 0; i--)
            {
                newBuffer[count] = buffer[i - 1];
                count++;

            }

            return new string(newBuffer);
        }
        static void Main(string[] args)
        {

            Program p1 = new Program();

            CipherDelegate cd1 = new CipherDelegate(p1.caesarCipher);
            CipherDelegate cd2 = new CipherDelegate(p1.reverseCipher);

            Console.WriteLine(cd1("hello"));

            Console.WriteLine(cd2("abcdefghijklmno"));


        }
    }
}
