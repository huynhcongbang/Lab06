using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryption_converter.Encryption
{
    public class Trithemius
    {
        public string Encrypt(string PlainText)
        {
            string cipher = "";
            PlainText = PlainText.ToUpper();

            for(int i = 0; i < PlainText.Length; i++)
            {
                char letter = PlainText[i];
                if(letter != ' ')
                {
                    int number = letter - 65;
                    number = (number + (i % 26)) % 26;
                    cipher += (char)(number + 65);
                }
                else
                {
                    cipher += ' ';
                }
            }

            return cipher;
        }

        public string Descrypt(string CipherText)
        {
            string PlainText = "";
            CipherText = CipherText.ToUpper();

            for(int i = 0; i < CipherText.Length; i++)
            {
                char letter = CipherText[i];
                if (letter != ' ')
                {
                    int number = letter - 65;
                    number = (number - (i % 26)) % 26;
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
