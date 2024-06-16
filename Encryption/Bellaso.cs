using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryption_converter.Encryption
{
    public class Bellaso
    {
        public string Encrypt(string PlainText, string Key)
        {
            string Cipher = "";

            for(int i = 0; i < PlainText.Length; i++)
            {
                char Letter = PlainText[i];
                if(Letter != ' ')
                {
                    int Row = Key[i % Key.Length] - 65;
                    int Col = Letter - 65;
                    int Number = (Row + Col) % 26;
                    Cipher += (char) (Number + 65);
                }
                else
                {
                    Cipher += ' ';
                }
            }

            return Cipher;
        }

        public string Descrypt(string PlainText, string Key)
        {
            string Decipher = "";

            for(int i = 0; i < PlainText.Length;i++)
            {
                char Letter = PlainText[i];
                if(Letter != ' ')
                {
                    int Row = Key[i % Key.Length] - 65;
                    int Col = Letter - 65;
                    int Number = (Col - Row + 26) % 26;
                    Decipher += (char)Number + 65;
                }
                else
                {
                    Decipher += ' ';
                }
            }

            return Decipher;
        }
    }
}
