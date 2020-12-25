using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptography.Ciphers
{
    class Double_permutation_of_characters
    {
        private string keyWord1;
        private string keyWord2;
        private string Text;
        private char[,] TableEncode;
        private char[,] TableDecode;

        /// <summary>
        /// keyWord1 - первый ключ (Определяет перестановку столбцов)
        /// keyWord2 - второй ключ (Определяет перестановку строк)
        /// text - текст, который нужно зашифровать или расшифровать.
        /// </summary>
        /// <param name="keyWord1"></param>
        /// <param name="keyWord2"></param>
        /// <param name="Text"></param>
        public Double_permutation_of_characters(string keyWord1, string keyWord2, string Text)
        {
            this.keyWord1 = keyWord1.ToUpper();
            this.keyWord2 = keyWord2.ToUpper();
            this.Text = Text.ToUpper();
        }

        /// <summary>
        /// Возвращает зашифрованную строку
        /// Return encode string
        /// </summary>
        /// <returns></returns>
        public string Encoded()
        {
            string Code = "";
            Encoding();

            for (int i = 1; i < keyWord1.Length + 1; ++i)
            {
                for (int j = 1; j < keyWord2.Length + 1; ++j)       // keyWord 1 = СКАНЕР
                {                                                   // keyWord 2 = 4123 
                    Code += TableEncode[j, i].ToString();
                }
            }

            return Code;
        }

        /// <summary>
        /// Возвращает расшифрованную строку
        /// Return decoded string
        /// </summary>
        /// <returns></returns>
        public string Decoded()
        {
            string Code = "";
            Decoding();

            for (int i = 1; i < keyWord2.Length + 1; ++i)
            {
                for (int j = 1; j < keyWord1.Length + 1; ++j)
                {
                    Code += TableDecode[j, i].ToString();
                }
            }

            return Code;
        }

        private void Encoding()
        {
            TableEncode = new char[keyWord2.Length + 1, keyWord1.Length + 1];

            int n = 0;
            TableEncode[0, 0] = ' ';
            for (int i = 1; i < keyWord2.Length + 1; ++i)
            {
                TableEncode[i, 0] = keyWord2[i - 1];
                for (int j = 1; j < keyWord1.Length + 1; ++j)       // keyWord 1 = СКАНЕР
                {                                                   // keyWord 2 = 4123 
                    TableEncode[0, j] = keyWord1[j - 1];
                    if (n == Text.Length)
                        TableEncode[i, j] = ' ';
                    TableEncode[i, j] = Text[n];
                    n++;
                }
            }

            // permutation of columns
            for (int i = 1; i < keyWord1.Length; ++i)
            {
                for (int j = i + 1; j < keyWord1.Length + 1; ++j)
                {
                    if (TableEncode[0, i] > TableEncode[0, j])
                        for (int k = 0; k < keyWord2.Length + 1; ++k)
                            Swap(ref TableEncode[k, i], ref TableEncode[k, j]);
                }
            }

            // permutation of lines
            for (int i = 1; i < keyWord2.Length; ++i)
            {
                for (int j = i + 1; j < keyWord2.Length + 1; ++j)
                {
                    if (TableEncode[i, 0] > TableEncode[j, 0])
                        for (int k = 0; k < keyWord1.Length + 1; ++k)
                            Swap(ref TableEncode[i, k], ref TableEncode[j, k]);
                }
            }
        }

        private void Decoding()
        {
            TableDecode = new char[keyWord1.Length + 1, keyWord2.Length + 1];

            char[] SortedkeyWord1 = SortString(keyWord1).ToCharArray();
            char[] SortedkeyWord2 = SortString(keyWord2).ToCharArray();

            int n = 0;
            TableDecode[0, 0] = ' ';
            for (int i = 1; i < SortedkeyWord1.Length + 1; ++i)
            {
                TableDecode[i, 0] = SortedkeyWord1[i - 1];
                for (int j = 1; j < SortedkeyWord2.Length + 1; ++j)       // keyWord 1 = СКАНЕР
                {                                                   // keyWord 2 = 4123 
                    TableDecode[0, j] = SortedkeyWord2[j - 1];
                    TableDecode[i, j] = Text[n];
                    n++;
                }
            }

            // permutation of columns
            for (int i = 0; i < keyWord2.Length; ++i)
            {
                for (int j = i; j < keyWord2.Length; ++j)
                {
                    if (keyWord2[i] == SortedkeyWord2[j])
                    {
                        for (int k = 0; k < SortedkeyWord1.Length + 1; ++k)
                            Swap(ref TableDecode[k, i + 1], ref TableDecode[k, j + 1]);

                        Swap(ref SortedkeyWord2[i], ref SortedkeyWord2[j]);
                    }
                }
            }

            // permutation of lines
            for (int i = 0; i < keyWord1.Length; ++i)
            {
                for (int j = i; j < keyWord1.Length; ++j)
                {
                    if (keyWord1[i] == SortedkeyWord1[j])
                    {
                        for (int k = 0; k < SortedkeyWord2.Length + 1; ++k)
                            Swap(ref TableDecode[i + 1, k], ref TableDecode[j + 1, k]);

                        Swap(ref SortedkeyWord1[i], ref SortedkeyWord1[j]);
                    }
                }
            }

        }

        private void Swap(ref char A, ref char B)
        {
            char ch = A;
            A = B;
            B = ch;
        }

        private string SortString(string Text)
        {
            char[] text = Text.ToCharArray();
            char temp;
            for (int i = 0; i < text.Length - 1; i++)
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] > text[j])
                    {
                        temp = text[i];
                        text[i] = text[j];
                        text[j] = temp;
                    }
                }
            }

            return new string(text);
        }
    }
}

