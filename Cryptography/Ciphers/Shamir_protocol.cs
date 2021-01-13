using System;
using System.Collections.Generic;
using System.Text;

// lab 2
namespace Cryptography.Ciphers
{
    class Shamir_protocol
    {
        private string literalText;
        private long numericText;
        
        private int Key;
        private int OpenKeyA;
        private int OpenKeyB;
        
        private int CloseKeyA;
        private int CloseKeyB;
        
        private int d_A;
        private int d_B;

        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private Dictionary<char, int> ABC;
        /// <summary>
        /// Key = int !!!
        /// GCD(CloseKeyA, Key - 1) = 1 !!!
        /// GCD(CloseKeyB, Key - 1) = 1 !!!
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="text"></param>
        /// <param name="OpenKeyA"></param>
        /// <param name="OpenKeyB"></param>
        public Shamir_protocol(string Key, string text, string CloseKeyA, string CloseKeyB)
        {
            this.Key = Convert.ToInt32(Key);
            this.literalText = text.ToUpper();
            this.CloseKeyA = Convert.ToInt32(CloseKeyA);
            this.CloseKeyB = Convert.ToInt32(CloseKeyA);
            d_A = Convert.ToInt32(Math.Pow(this.CloseKeyA, -1));
            d_B = Convert.ToInt32(Math.Pow(this.CloseKeyB, -1));

            int i = 1;
            foreach (var symbol in alphabet)
            {
                ABC.Add(symbol, i++);
            }

            for (int j = literalText.Length - 1; i >= 0; ++i)
            {
                numericText += Convert.ToInt64(ABC[literalText[literalText.Length - j]]) * Convert.ToInt64(Math.Pow(alphabet.Length, j));
            }
        }

        /// <summary>
        /// Возвращает зашифрованную строку
        /// Return encode string
        /// </summary>
        /// <returns></returns>
        public string Encode()
        {
            string code = "";

            

            return code;
        }

        /// <summary>
        /// Возвращает расшифрованную строку
        /// Return decode string
        /// </summary>
        /// <returns></returns>
        public string Decode()
        {
            string code = "";

            

            return code;
        }

        private void Encoding()
        {
            int alpha = OpenKeyA;
            int beta = OpenKeyB;


        }

        private void Decoding()
        {

        }


        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
    }
}
