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
            string text = richTextBoxDoublePocIn.Text;
            string keyA = textBoxDoublePocKeyA.Text;
            string keyB = textBoxDoublePocKeyB.Text;
            DoublePermutationOfCharacters doublePermutationOfCharacters = new DoublePermutationOfCharacters(keyA, keyB, text);

            richTextBoxDoublePocOut.Text = doublePermutationOfCharacters.Encode();
        }

        private void buttonDoublePocDecode_Click(object sender, EventArgs e)
        {
            string text = richTextBoxDoublePocIn.Text;
            string keyA = textBoxDoublePocKeyA.Text;
            string keyB = textBoxDoublePocKeyB.Text;
            DoublePermutationOfCharacters doublePermutationOfCharacters = new DoublePermutationOfCharacters(keyA, keyB, text);

            richTextBoxDoublePocOut.Text = doublePermutationOfCharacters.Decode();
        }
    }
}
