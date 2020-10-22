// This code was written by Karolis Vaitele

using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    public class Caesar
    {
        static void Main(string[] args)
        {

        }
        public char CipherLetter(char letter, int shift)
        {
            char startingLetter = char.IsLower(letter) ? 'a' : 'A';

            return (char)((letter + shift - startingLetter)%26 + startingLetter);
        }
        public string Encrypt(string phrase, int shift)
        {
            StringBuilder encryption = new StringBuilder();

            if (shift < 0)
            {
                shift %= 26;
                shift += 26;
            }

            foreach (char letter in phrase)
            {
                if (char.IsLetter(letter))
                    encryption.Append(CipherLetter(letter, shift));
                else
                    encryption.Append(letter);
            }

            return encryption.ToString();
        }
        public string Decrypt(string phrase, int shift)
        {
            return Encrypt(phrase, 26 - shift);
        }
    }
}
