using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptography.Ciphers
{
    class Affine_Caesar_Cipher
    {
        private string strEuABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private char[] EuABC;
        private int a;
        private int b;
        private string text;

        private Dictionary<char, char> EuEncoding = new Dictionary<char, char>();
        private Dictionary<char, char> EuDecoding = new Dictionary<char, char>();


        // a и b должны быть взаимно простыми
        // НОД (а, 26(длина алфавита)) = 1 !!!
        // Добавить какую-то проверку !

        public Affine_Caesar_Cipher(string A, string B, string text)
        {
            char[] EuABC = strEuABC.ToCharArray();
            this.a = Convert.ToInt32(a);
            this.b = Convert.ToInt32(b);
            this.text = text;

            for (int i = 0; i < EuABC.Length; i++)
            {
                EuEncoding.Add(EuABC[i], EuABC[(a * i + b) % EuABC.Length]);
                EuDecoding.Add(EuABC[(a * i + b) % EuABC.Length], EuABC[i]);
            }
        }

        /// <summary>
        /// Return encode string by Affine Ceasar cipher
        /// </summary>
        /// <returns></returns>
        public string Encode()
        {
            string code = "";

            foreach (char symbol in text)
            {
                code += EuEncoding[symbol].ToString();
            }

            return code;
        }

        /// <summary>
        /// Return decode string by Affine Ceasar cipher
        /// </summary>
        /// <returns></returns>
        public string Decode()
        {
            string code = "";

            foreach (char symbol in text)
            {
                code += EuDecoding[symbol].ToString();
            }

            return code;
        }
    }
}
