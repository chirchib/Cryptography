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
        /// Нажатие на кнопку Зашифровать в Двойном квдарате Уитстона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWheatstoneDoubleSquareEncode_Click(object sender, EventArgs e)
        {
            try
            {
                string text = richTextBoxWheatstoneDoubleSquareIn.Text;
                string keyA = textBoxWheatstoneDoubleSquareKeyA.Text;
                string keyB = textBoxWheatstoneDoubleSquareKeyB.Text;
                WheatstoneDoubleSquare wheatstoneDoubleSquare = new WheatstoneDoubleSquare(keyA, keyB, text);

                richTextBoxWheatstoneDoubleSquareOut.Text = wheatstoneDoubleSquare.Encode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Нажатие на кнопку Расшифровать в Двойном квдарате Уитстона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWheatstoneDoubleSquareDecode_Click(object sender, EventArgs e)
        {
            try
            {
                string text = richTextBoxWheatstoneDoubleSquareIn.Text;
                string keyA = textBoxWheatstoneDoubleSquareKeyA.Text;
                string keyB = textBoxWheatstoneDoubleSquareKeyB.Text;
                WheatstoneDoubleSquare wheatstoneDoubleSquare = new WheatstoneDoubleSquare(keyA, keyB, text);

                richTextBoxWheatstoneDoubleSquareOut.Text = wheatstoneDoubleSquare.Decode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Нажатие на кнопку Зашифровать в Методе двойной перестановки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDoublePocEncode_Click(object sender, EventArgs e)
        {
            try
            {

                DoublePermutationOfCharacters doublePermutation = 
                    new DoublePermutationOfCharacters(
                        richTextBoxDoublePocIn.Text, 
                        textBoxDoublePocKeyA.Text, 
                        textBoxDoublePocKeyB.Text);
                richTextBoxDoublePocOut.Text = doublePermutation.Encode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Нажатие на кнопку Расшифровать в Методе двойной перестановки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDoublePocDecode_Click(object sender, EventArgs e)
        {
            try
            {

                DoublePermutationOfCharacters doublePermutation =
                    new DoublePermutationOfCharacters(
                        richTextBoxDoublePocIn.Text,
                        textBoxDoublePocKeyA.Text,
                        textBoxDoublePocKeyB.Text);
                richTextBoxDoublePocOut.Text = doublePermutation.Decode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Нажатие на кнопку Зашифровать в Система Цезаря с ключевым словом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCaesarEncode_Click(object sender, EventArgs e)
        {
            try
            {
                string text = richTextBoxCaesarIn.Text;
                string keyNum = textBoxCaesarKeyNum.Text;
                string keyString = textBoxCaesarKeyString.Text;
                CaesarCipher caesarCipher = new CaesarCipher(keyString, Convert.ToInt32(keyNum), text);
                richTextBoxCaesarOut.Text = caesarCipher.Encode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Нажатие на кнопку Расшифровать в Система Цезаря с ключевым словом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCaesarDecode_Click(object sender, EventArgs e)
        {
            try
            {
                string text = richTextBoxCaesarIn.Text;
                string keyNum = textBoxCaesarKeyNum.Text;
                string keyString = textBoxCaesarKeyString.Text;
                CaesarCipher caesarCipher = new CaesarCipher(keyString, Convert.ToInt32(keyNum), text);
                richTextBoxCaesarOut.Text = caesarCipher.Decode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Нажатие на кнопку Зашифровать в Афинная система подстановок Цезаря
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAffineCaesarEncode_Click(object sender, EventArgs e)
        {
            try
            {
                string text = richTextBoxAffineCaesarIn.Text;
                string keyA = textBoxAffineCaesarKeyB.Text;
                string keyB = textBoxAffineCaesarKeyA.Text;
                AffineCaesarCipher affineCaesar = new AffineCaesarCipher(Convert.ToInt32(keyA), Convert.ToInt32(keyB), text);
                richTextBoxAffineCaesarOut.Text = affineCaesar.Encode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Нажатие на кнопку Расшифровать в Афинная система подстановок Цезаря
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAffineCaesarDecode_Click(object sender, EventArgs e)
        {
            try
            {
                string text = richTextBoxAffineCaesarIn.Text;
                string keyA = textBoxAffineCaesarKeyB.Text;
                string keyB = textBoxAffineCaesarKeyB.Text;
                AffineCaesarCipher affineCaesar = new AffineCaesarCipher(Convert.ToInt32(keyA), Convert.ToInt32(keyB), text);
                richTextBoxAffineCaesarOut.Text = affineCaesar.Decode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAffineCaesarKeyA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAffineCaesarKeyB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
