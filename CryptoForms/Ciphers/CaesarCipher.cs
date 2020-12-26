using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciphers
{
    class CaesarCipher
    {
        private string strEuABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private char[] EuABC;
        int KeyNum = Convert.ToInt32(Console.ReadLine());
        string KeyWord;
        private string text;

        private Dictionary<char, char> EuEncoding = new Dictionary<char, char>();
        private Dictionary<char, char> EuDecoding = new Dictionary<char, char>();

        private char[] EuABCwithoutKeyWord;
        private char[] EuABCwithCipher = new char[26];

        /// <summary>
        /// keyNum - ключевое число от 0 до 25, keyWord - ключевое слово, 
        /// text - текст, который нужно зашифровать или расшифровать.
        /// </summary>
        /// <param name="keyNum"></param>
        /// <param name="keyWord"></param>
        /// <param name="text"></param>
        public CaesarCipher(string keyNum, string keyWord, string text)
        {
            EuABC = strEuABC.ToCharArray();
            this.KeyNum = Convert.ToInt32(keyNum);
            this.KeyWord = new string(keyWord.Distinct().ToArray()).Replace(" ", "").ToUpper(); ; // Удаляет пробелы и повторяющиеся символы
            this.text = text;
            
            foreach (char symbol in KeyWord)
            {
                strEuABC = strEuABC.Remove(strEuABC.IndexOf(symbol), 1);
            }
            char[] EuABCwithoutKeyWord = strEuABC.ToCharArray();

            int k = 0; // auxiliary index 
            for (int i = KeyNum, j = 0; j < KeyWord.Length || i < EuABC.Length; j++, i++)
            {
                if (j < KeyWord.Length)
                {
                    EuABCwithCipher[i] = KeyWord[j];
                }
                else
                {
                    EuABCwithCipher[i] = EuABCwithoutKeyWord[k];
                    k++;
                }
            }
            for (int i = 0; i < KeyNum; i++)
            {
                EuABCwithCipher[i] = EuABCwithoutKeyWord[k];
                k++;
            }

            for (int i = 0; i < EuABC.Length; i++)
            {
                EuEncoding.Add(EuABC[i], EuABCwithCipher[i]);
                EuDecoding.Add(EuABCwithCipher[i], EuABC[i]);
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

            foreach (char symbol in text)
            {
                code += EuEncoding[symbol].ToString();
            }

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

            foreach (char symbol in text)
            {
                code += EuDecoding[symbol].ToString();
            }

            return code;
        }
    }
}
