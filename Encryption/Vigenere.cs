using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryption_converter.Encryption
{
    public class Vigenere
    {
        public string Encrypt(string PlainText, string Key)
        {
            string Cipher = "";
            PlainText = PlainText.ToUpper();

            for(int i = 0; i < PlainText.Length;i++)
            {
                char letter = PlainText[i];
                int position = i % Key.Length;
                if(letter != ' ')
                {
                    int number = letter - 65;
                    int NumberKey = Key[position] - 65;
                    number = (number + NumberKey) % 26;
                    Cipher += (char)(number + 65);
                }
                else
                {
                    Cipher += Key[position];
                }
            }
            return Cipher;
        }

        public string Descrypt(string CipherText, string Key)
        {
            string PlainText = "";

            for (int i = 0; i < CipherText.Length; i++)
            {
                char letter = CipherText[i];
                int position = i % Key.Length;
                if (letter != ' ')
                {
                    int number = letter - 65;
                    int NumberKey = Key[position] - 65;
                    number = (number - NumberKey + 26) % 26;
                    PlainText += (char)(number + 65);
                }
                else
                {
                    PlainText += ' ';
                }
            }

            return PlainText;
        }
    }
}
