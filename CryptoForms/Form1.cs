using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ciphers;

namespace CryptoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка на коректность ввода ключей 4 шифра
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Alphabet"></param>
        /// <returns></returns>
        private bool IsCorrectText(string str, string Alphabet)
        {
            if (int.TryParse(str.Trim(), out int number))
            {
                return false;
            }
            else
            {
                int ch = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < Alphabet.Length; j++)
                    {
                        if (str[i].ToString() == Alphabet[j].ToString())
                        {
                            ch++;
                        }
                    }
                }
                return (str.Length == ch) ? false : true;
            }
        }

        /// <summary>
        /// Проверка на уникальность строки
        /// </summary>
        /// <param name="str">Строка для проверки</param>
        /// <returns></returns>
        private bool IsUniqueString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str.IndexOf(str[i]) != str.LastIndexOf(str[i]))
                {
                    return true;
                }
            }
            return false;
        }


        private void buttonWheatstoneDoubleSquareEncode_Click(object sender, EventArgs e)
        {
            string text = richTextBoxWheatstoneDoubleSquareIn.Text;
            string keyA = textBoxWheatstoneDoubleSquareKeyA.Text;
            string keyB = textBoxWheatstoneDoubleSquareKeyB.Text;
            WheatstoneDoubleSquare wheatstoneDoubleSquare = new WheatstoneDoubleSquare(keyA, keyB,text);

            richTextBoxWheatstoneDoubleSquareOut.Text = wheatstoneDoubleSquare.Encode();


        }

        private void buttonWheatstoneDoubleSquareDecode_Click(object sender, EventArgs e)
        {
            string text = richTextBoxWheatstoneDoubleSquareIn.Text;
            string keyA = textBoxWheatstoneDoubleSquareKeyA.Text;
            string keyB = textBoxWheatstoneDoubleSquareKeyB.Text;
            WheatstoneDoubleSquare wheatstoneDoubleSquare = new WheatstoneDoubleSquare(keyA, keyB, text);

            richTextBoxWheatstoneDoubleSquareOut.Text = wheatstoneDoubleSquare.Decode();

        }

        private void buttonDoublePocEncode_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxDoublePocKeyA.Text))
                    throw new Exception("Поле первого ключа обязательно к заполнению");
                DoublePermutationOfCharacters doublePermutation = new DoublePermutationOfCharacters(richTextBoxDoublePocIn.Text, textBoxDoublePocKeyA.Text, textBoxDoublePocKeyB.Text, out int Height, out string Alphabet);
                if (textBoxDoublePocKeyB.Text.Length != Height)
                    throw new Exception($"Длина второго ключа должна равняться {Height}");
                if (IsCorrectText(textBoxDoublePocKeyA.Text, Alphabet) || IsCorrectText(textBoxDoublePocKeyB.Text, Alphabet))
                    throw new Exception($"Ключи должны быть в виде числа или слова (без комбинаций!)");
                if (textBoxDoublePocKeyB.Text.Length > 10)
                    throw new Exception($"Предельная длина 2 ключа, первый ключ должен быть длиннее");
                if (IsUniqueString(textBoxDoublePocKeyA.Text) || IsUniqueString(textBoxDoublePocKeyB.Text))
                    throw new Exception($"Ключи должны состоять из уникальных символов!");


                richTextBoxDoublePocOut.Text = doublePermutation.Encode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDoublePocDecode_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxDoublePocKeyA.Text))
                    throw new Exception("Поле первого ключа обязательно к заполнению");
                DoublePermutationOfCharacters doublePermutation = new DoublePermutationOfCharacters(richTextBoxDoublePocIn.Text, textBoxDoublePocKeyA.Text, textBoxDoublePocKeyB.Text, out int Height, out string Alphabet);
                if (textBoxDoublePocKeyB.Text.Length != Height)
                    throw new Exception($"Длина второго ключа должна равняться {Height}");
                if (IsCorrectText(textBoxDoublePocKeyA.Text, Alphabet) || IsCorrectText(textBoxDoublePocKeyB.Text, Alphabet))
                    throw new Exception($"Ключи должны быть в виде числа или слова (без комбинаций!)");
                if (textBoxDoublePocKeyB.Text.Length > 10)
                    throw new Exception($"Предельная длина 2 ключа, первый ключ должен быть длиннее");
                if (IsUniqueString(textBoxDoublePocKeyA.Text) || IsUniqueString(textBoxDoublePocKeyB.Text))
                    throw new Exception($"Ключи должны состоять из уникальных символов!");


                richTextBoxDoublePocOut.Text = doublePermutation.Decode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCaesarEncode_Click(object sender, EventArgs e)
        {
            string text = richTextBoxCaesarIn.Text;
            string keyNum = textBoxCaesarKeyNum.Text;
            string keyString = textBoxCaesarKeyString.Text;
            CaesarCipher caesarCipher = new CaesarCipher(keyNum, keyString, text);

            richTextBoxCaesarOut.Text = caesarCipher.Encode();
        }

        private void buttonbuttonCaesarDecode_Click(object sender, EventArgs e)
        {
            string text = richTextBoxCaesarIn.Text;
            string keyNum = textBoxCaesarKeyNum.Text;
            string keyString = textBoxCaesarKeyString.Text;
            CaesarCipher caesarCipher = new CaesarCipher(keyNum, keyString, text);

            richTextBoxCaesarOut.Text = caesarCipher.Decode();
        }
    }
}
