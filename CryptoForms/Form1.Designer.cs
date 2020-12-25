
namespace CryptoForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCaesar = new System.Windows.Forms.TabPage();
            this.buttonbuttonCaesarDecode = new System.Windows.Forms.Button();
            this.buttonCaesarEncode = new System.Windows.Forms.Button();
            this.richTextBoxCaesarOut = new System.Windows.Forms.RichTextBox();
            this.labelCaesarKeyString = new System.Windows.Forms.Label();
            this.labelCaesarKeyNum = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textCaesarKeyNum = new System.Windows.Forms.TextBox();
            this.richTextBoxCaesarIn = new System.Windows.Forms.RichTextBox();
            this.tabPageAffineCaesar = new System.Windows.Forms.TabPage();
            this.buttonAffineCaesarDecode = new System.Windows.Forms.Button();
            this.buttonAffineCaesarEncode = new System.Windows.Forms.Button();
            this.richTextBoxAffineCaesarOut = new System.Windows.Forms.RichTextBox();
            this.labelAffineCaesarKeyB = new System.Windows.Forms.Label();
            this.labelAffineCaesarKeyA = new System.Windows.Forms.Label();
            this.textBoxAffineCaesarKeyN = new System.Windows.Forms.TextBox();
            this.textBoxAffineCaesarKeyA = new System.Windows.Forms.TextBox();
            this.richTextBoxAffineCaesarIn = new System.Windows.Forms.RichTextBox();
            this.tabPageWhearstoneDoubleSquare = new System.Windows.Forms.TabPage();
            this.buttonWheatstoneDoubleSquareDecode = new System.Windows.Forms.Button();
            this.buttonWheatstoneDoubleSquareEncode = new System.Windows.Forms.Button();
            this.richTextBoxWheatstoneDoubleSquareOut = new System.Windows.Forms.RichTextBox();
            this.labelWheatstoneDoubleSquareKeyB = new System.Windows.Forms.Label();
            this.labelWheatstoneDoubleSquareKeyA = new System.Windows.Forms.Label();
            this.textBoxWheatstoneDoubleSquareB = new System.Windows.Forms.TextBox();
            this.textBoxWheatstoneDoubleSquareKeyA = new System.Windows.Forms.TextBox();
            this.richTextBoxWheatstoneDoubleSquareIn = new System.Windows.Forms.RichTextBox();
            this.tabPageDoublePoc = new System.Windows.Forms.TabPage();
            this.buttonDoublePocDecode = new System.Windows.Forms.Button();
            this.buttonDoublePocEncode = new System.Windows.Forms.Button();
            this.richTextBoxDoublePocOut = new System.Windows.Forms.RichTextBox();
            this.labelDoublePocKeyB = new System.Windows.Forms.Label();
            this.labelDoublePocKeyA = new System.Windows.Forms.Label();
            this.textBoxDoublePocKeyB = new System.Windows.Forms.TextBox();
            this.textBoxDoublePocKeyA = new System.Windows.Forms.TextBox();
            this.richTextBoxDoublePocIn = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageCaesar.SuspendLayout();
            this.tabPageAffineCaesar.SuspendLayout();
            this.tabPageWhearstoneDoubleSquare.SuspendLayout();
            this.tabPageDoublePoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCaesar);
            this.tabControl1.Controls.Add(this.tabPageAffineCaesar);
            this.tabControl1.Controls.Add(this.tabPageWhearstoneDoubleSquare);
            this.tabControl1.Controls.Add(this.tabPageDoublePoc);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCaesar
            // 
            this.tabPageCaesar.Controls.Add(this.buttonbuttonCaesarDecode);
            this.tabPageCaesar.Controls.Add(this.buttonCaesarEncode);
            this.tabPageCaesar.Controls.Add(this.richTextBoxCaesarOut);
            this.tabPageCaesar.Controls.Add(this.labelCaesarKeyString);
            this.tabPageCaesar.Controls.Add(this.labelCaesarKeyNum);
            this.tabPageCaesar.Controls.Add(this.textBox2);
            this.tabPageCaesar.Controls.Add(this.textCaesarKeyNum);
            this.tabPageCaesar.Controls.Add(this.richTextBoxCaesarIn);
            this.tabPageCaesar.Location = new System.Drawing.Point(4, 25);
            this.tabPageCaesar.Name = "tabPageCaesar";
            this.tabPageCaesar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCaesar.Size = new System.Drawing.Size(768, 397);
            this.tabPageCaesar.TabIndex = 0;
            this.tabPageCaesar.Text = "Caesar";
            this.tabPageCaesar.UseVisualStyleBackColor = true;
            // 
            // buttonbuttonCaesarDecode
            // 
            this.buttonbuttonCaesarDecode.Location = new System.Drawing.Point(500, 171);
            this.buttonbuttonCaesarDecode.Name = "buttonbuttonCaesarDecode";
            this.buttonbuttonCaesarDecode.Size = new System.Drawing.Size(138, 28);
            this.buttonbuttonCaesarDecode.TabIndex = 15;
            this.buttonbuttonCaesarDecode.Text = "Расшифровать";
            this.buttonbuttonCaesarDecode.UseVisualStyleBackColor = true;
            // 
            // buttonCaesarEncode
            // 
            this.buttonCaesarEncode.Location = new System.Drawing.Point(644, 171);
            this.buttonCaesarEncode.Name = "buttonCaesarEncode";
            this.buttonCaesarEncode.Size = new System.Drawing.Size(120, 28);
            this.buttonCaesarEncode.TabIndex = 14;
            this.buttonCaesarEncode.Text = "Зашифровать";
            this.buttonCaesarEncode.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCaesarOut
            // 
            this.richTextBoxCaesarOut.Location = new System.Drawing.Point(8, 205);
            this.richTextBoxCaesarOut.Name = "richTextBoxCaesarOut";
            this.richTextBoxCaesarOut.ReadOnly = true;
            this.richTextBoxCaesarOut.Size = new System.Drawing.Size(756, 187);
            this.richTextBoxCaesarOut.TabIndex = 13;
            this.richTextBoxCaesarOut.Text = "";
            // 
            // labelCaesarKeyString
            // 
            this.labelCaesarKeyString.AutoSize = true;
            this.labelCaesarKeyString.Location = new System.Drawing.Point(245, 177);
            this.labelCaesarKeyString.Name = "labelCaesarKeyString";
            this.labelCaesarKeyString.Size = new System.Drawing.Size(116, 17);
            this.labelCaesarKeyString.TabIndex = 12;
            this.labelCaesarKeyString.Text = "Ключевое слово";
            // 
            // labelCaesarKeyNum
            // 
            this.labelCaesarKeyNum.AutoSize = true;
            this.labelCaesarKeyNum.Location = new System.Drawing.Point(5, 177);
            this.labelCaesarKeyNum.Name = "labelCaesarKeyNum";
            this.labelCaesarKeyNum.Size = new System.Drawing.Size(121, 17);
            this.labelCaesarKeyNum.TabIndex = 11;
            this.labelCaesarKeyNum.Text = "Ключевая цифра";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textCaesarKeyNum
            // 
            this.textCaesarKeyNum.CausesValidation = false;
            this.textCaesarKeyNum.Location = new System.Drawing.Point(132, 174);
            this.textCaesarKeyNum.Name = "textCaesarKeyNum";
            this.textCaesarKeyNum.Size = new System.Drawing.Size(107, 22);
            this.textCaesarKeyNum.TabIndex = 9;
            // 
            // richTextBoxCaesarIn
            // 
            this.richTextBoxCaesarIn.Location = new System.Drawing.Point(8, 4);
            this.richTextBoxCaesarIn.Name = "richTextBoxCaesarIn";
            this.richTextBoxCaesarIn.Size = new System.Drawing.Size(756, 164);
            this.richTextBoxCaesarIn.TabIndex = 8;
            this.richTextBoxCaesarIn.Text = "";
            // 
            // tabPageAffineCaesar
            // 
            this.tabPageAffineCaesar.Controls.Add(this.buttonAffineCaesarDecode);
            this.tabPageAffineCaesar.Controls.Add(this.buttonAffineCaesarEncode);
            this.tabPageAffineCaesar.Controls.Add(this.richTextBoxAffineCaesarOut);
            this.tabPageAffineCaesar.Controls.Add(this.labelAffineCaesarKeyB);
            this.tabPageAffineCaesar.Controls.Add(this.labelAffineCaesarKeyA);
            this.tabPageAffineCaesar.Controls.Add(this.textBoxAffineCaesarKeyN);
            this.tabPageAffineCaesar.Controls.Add(this.textBoxAffineCaesarKeyA);
            this.tabPageAffineCaesar.Controls.Add(this.richTextBoxAffineCaesarIn);
            this.tabPageAffineCaesar.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffineCaesar.Name = "tabPageAffineCaesar";
            this.tabPageAffineCaesar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAffineCaesar.Size = new System.Drawing.Size(768, 397);
            this.tabPageAffineCaesar.TabIndex = 1;
            this.tabPageAffineCaesar.Text = "Affine Caesar";
            this.tabPageAffineCaesar.UseVisualStyleBackColor = true;
            // 
            // buttonAffineCaesarDecode
            // 
            this.buttonAffineCaesarDecode.Location = new System.Drawing.Point(500, 171);
            this.buttonAffineCaesarDecode.Name = "buttonAffineCaesarDecode";
            this.buttonAffineCaesarDecode.Size = new System.Drawing.Size(138, 28);
            this.buttonAffineCaesarDecode.TabIndex = 15;
            this.buttonAffineCaesarDecode.Text = "Расшифровать";
            this.buttonAffineCaesarDecode.UseVisualStyleBackColor = true;
            // 
            // buttonAffineCaesarEncode
            // 
            this.buttonAffineCaesarEncode.Location = new System.Drawing.Point(644, 171);
            this.buttonAffineCaesarEncode.Name = "buttonAffineCaesarEncode";
            this.buttonAffineCaesarEncode.Size = new System.Drawing.Size(120, 28);
            this.buttonAffineCaesarEncode.TabIndex = 14;
            this.buttonAffineCaesarEncode.Text = "Зашифровать";
            this.buttonAffineCaesarEncode.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAffineCaesarOut
            // 
            this.richTextBoxAffineCaesarOut.Location = new System.Drawing.Point(8, 205);
            this.richTextBoxAffineCaesarOut.Name = "richTextBoxAffineCaesarOut";
            this.richTextBoxAffineCaesarOut.ReadOnly = true;
            this.richTextBoxAffineCaesarOut.Size = new System.Drawing.Size(756, 187);
            this.richTextBoxAffineCaesarOut.TabIndex = 13;
            this.richTextBoxAffineCaesarOut.Text = "";
            // 
            // labelAffineCaesarKeyB
            // 
            this.labelAffineCaesarKeyB.AutoSize = true;
            this.labelAffineCaesarKeyB.Location = new System.Drawing.Point(239, 177);
            this.labelAffineCaesarKeyB.Name = "labelAffineCaesarKeyB";
            this.labelAffineCaesarKeyB.Size = new System.Drawing.Size(56, 17);
            this.labelAffineCaesarKeyB.TabIndex = 12;
            this.labelAffineCaesarKeyB.Text = "Ключ B";
            // 
            // labelAffineCaesarKeyA
            // 
            this.labelAffineCaesarKeyA.AutoSize = true;
            this.labelAffineCaesarKeyA.Location = new System.Drawing.Point(5, 177);
            this.labelAffineCaesarKeyA.Name = "labelAffineCaesarKeyA";
            this.labelAffineCaesarKeyA.Size = new System.Drawing.Size(56, 17);
            this.labelAffineCaesarKeyA.TabIndex = 11;
            this.labelAffineCaesarKeyA.Text = "Ключ A";
            // 
            // textBoxAffineCaesarKeyN
            // 
            this.textBoxAffineCaesarKeyN.Location = new System.Drawing.Point(301, 174);
            this.textBoxAffineCaesarKeyN.Name = "textBoxAffineCaesarKeyN";
            this.textBoxAffineCaesarKeyN.Size = new System.Drawing.Size(193, 22);
            this.textBoxAffineCaesarKeyN.TabIndex = 10;
            // 
            // textBoxAffineCaesarKeyA
            // 
            this.textBoxAffineCaesarKeyA.CausesValidation = false;
            this.textBoxAffineCaesarKeyA.Location = new System.Drawing.Point(67, 174);
            this.textBoxAffineCaesarKeyA.Name = "textBoxAffineCaesarKeyA";
            this.textBoxAffineCaesarKeyA.Size = new System.Drawing.Size(166, 22);
            this.textBoxAffineCaesarKeyA.TabIndex = 9;
            // 
            // richTextBoxAffineCaesarIn
            // 
            this.richTextBoxAffineCaesarIn.Location = new System.Drawing.Point(8, 4);
            this.richTextBoxAffineCaesarIn.Name = "richTextBoxAffineCaesarIn";
            this.richTextBoxAffineCaesarIn.Size = new System.Drawing.Size(756, 164);
            this.richTextBoxAffineCaesarIn.TabIndex = 8;
            this.richTextBoxAffineCaesarIn.Text = "";
            // 
            // tabPageWhearstoneDoubleSquare
            // 
            this.tabPageWhearstoneDoubleSquare.Controls.Add(this.buttonWheatstoneDoubleSquareDecode);
            this.tabPageWhearstoneDoubleSquare.Controls.Add(this.buttonWheatstoneDoubleSquareEncode);
            this.tabPageWhearstoneDoubleSquare.Controls.Add(this.richTextBoxWheatstoneDoubleSquareOut);
            this.tabPageWhearstoneDoubleSquare.Controls.Add(this.labelWheatstoneDoubleSquareKeyB);
            this.tabPageWhearstoneDoubleSquare.Controls.Add(this.labelWheatstoneDoubleSquareKeyA);
            this.tabPageWhearstoneDoubleSquare.Controls.Add(this.textBoxWheatstoneDoubleSquareB);
            this.tabPageWhearstoneDoubleSquare.Controls.Add(this.textBoxWheatstoneDoubleSquareKeyA);
            this.tabPageWhearstoneDoubleSquare.Controls.Add(this.richTextBoxWheatstoneDoubleSquareIn);
            this.tabPageWhearstoneDoubleSquare.Location = new System.Drawing.Point(4, 25);
            this.tabPageWhearstoneDoubleSquare.Name = "tabPageWhearstoneDoubleSquare";
            this.tabPageWhearstoneDoubleSquare.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWhearstoneDoubleSquare.Size = new System.Drawing.Size(768, 397);
            this.tabPageWhearstoneDoubleSquare.TabIndex = 2;
            this.tabPageWhearstoneDoubleSquare.Text = "Whearstone Double Square";
            this.tabPageWhearstoneDoubleSquare.UseVisualStyleBackColor = true;
            // 
            // buttonWheatstoneDoubleSquareDecode
            // 
            this.buttonWheatstoneDoubleSquareDecode.Location = new System.Drawing.Point(500, 171);
            this.buttonWheatstoneDoubleSquareDecode.Name = "buttonWheatstoneDoubleSquareDecode";
            this.buttonWheatstoneDoubleSquareDecode.Size = new System.Drawing.Size(138, 28);
            this.buttonWheatstoneDoubleSquareDecode.TabIndex = 15;
            this.buttonWheatstoneDoubleSquareDecode.Text = "Расшифровать";
            this.buttonWheatstoneDoubleSquareDecode.UseVisualStyleBackColor = true;
            // 
            // buttonWheatstoneDoubleSquareEncode
            // 
            this.buttonWheatstoneDoubleSquareEncode.Location = new System.Drawing.Point(644, 171);
            this.buttonWheatstoneDoubleSquareEncode.Name = "buttonWheatstoneDoubleSquareEncode";
            this.buttonWheatstoneDoubleSquareEncode.Size = new System.Drawing.Size(120, 28);
            this.buttonWheatstoneDoubleSquareEncode.TabIndex = 14;
            this.buttonWheatstoneDoubleSquareEncode.Text = "Зашифровать";
            this.buttonWheatstoneDoubleSquareEncode.UseVisualStyleBackColor = true;
            // 
            // richTextBoxWheatstoneDoubleSquareOut
            // 
            this.richTextBoxWheatstoneDoubleSquareOut.Location = new System.Drawing.Point(8, 205);
            this.richTextBoxWheatstoneDoubleSquareOut.Name = "richTextBoxWheatstoneDoubleSquareOut";
            this.richTextBoxWheatstoneDoubleSquareOut.ReadOnly = true;
            this.richTextBoxWheatstoneDoubleSquareOut.Size = new System.Drawing.Size(756, 187);
            this.richTextBoxWheatstoneDoubleSquareOut.TabIndex = 13;
            this.richTextBoxWheatstoneDoubleSquareOut.Text = "";
            // 
            // labelWheatstoneDoubleSquareKeyB
            // 
            this.labelWheatstoneDoubleSquareKeyB.AutoSize = true;
            this.labelWheatstoneDoubleSquareKeyB.Location = new System.Drawing.Point(245, 177);
            this.labelWheatstoneDoubleSquareKeyB.Name = "labelWheatstoneDoubleSquareKeyB";
            this.labelWheatstoneDoubleSquareKeyB.Size = new System.Drawing.Size(56, 17);
            this.labelWheatstoneDoubleSquareKeyB.TabIndex = 12;
            this.labelWheatstoneDoubleSquareKeyB.Text = "Ключ B";
            // 
            // labelWheatstoneDoubleSquareKeyA
            // 
            this.labelWheatstoneDoubleSquareKeyA.AutoSize = true;
            this.labelWheatstoneDoubleSquareKeyA.Location = new System.Drawing.Point(5, 177);
            this.labelWheatstoneDoubleSquareKeyA.Name = "labelWheatstoneDoubleSquareKeyA";
            this.labelWheatstoneDoubleSquareKeyA.Size = new System.Drawing.Size(56, 17);
            this.labelWheatstoneDoubleSquareKeyA.TabIndex = 11;
            this.labelWheatstoneDoubleSquareKeyA.Text = "Ключ A";
            // 
            // textBoxWheatstoneDoubleSquareB
            // 
            this.textBoxWheatstoneDoubleSquareB.Location = new System.Drawing.Point(307, 174);
            this.textBoxWheatstoneDoubleSquareB.Name = "textBoxWheatstoneDoubleSquareB";
            this.textBoxWheatstoneDoubleSquareB.Size = new System.Drawing.Size(187, 22);
            this.textBoxWheatstoneDoubleSquareB.TabIndex = 10;
            // 
            // textBoxWheatstoneDoubleSquareKeyA
            // 
            this.textBoxWheatstoneDoubleSquareKeyA.CausesValidation = false;
            this.textBoxWheatstoneDoubleSquareKeyA.Location = new System.Drawing.Point(67, 174);
            this.textBoxWheatstoneDoubleSquareKeyA.Name = "textBoxWheatstoneDoubleSquareKeyA";
            this.textBoxWheatstoneDoubleSquareKeyA.Size = new System.Drawing.Size(172, 22);
            this.textBoxWheatstoneDoubleSquareKeyA.TabIndex = 9;
            // 
            // richTextBoxWheatstoneDoubleSquareIn
            // 
            this.richTextBoxWheatstoneDoubleSquareIn.Location = new System.Drawing.Point(8, 4);
            this.richTextBoxWheatstoneDoubleSquareIn.Name = "richTextBoxWheatstoneDoubleSquareIn";
            this.richTextBoxWheatstoneDoubleSquareIn.Size = new System.Drawing.Size(756, 164);
            this.richTextBoxWheatstoneDoubleSquareIn.TabIndex = 8;
            this.richTextBoxWheatstoneDoubleSquareIn.Text = "";
            // 
            // tabPageDoublePoc
            // 
            this.tabPageDoublePoc.Controls.Add(this.buttonDoublePocDecode);
            this.tabPageDoublePoc.Controls.Add(this.buttonDoublePocEncode);
            this.tabPageDoublePoc.Controls.Add(this.richTextBoxDoublePocOut);
            this.tabPageDoublePoc.Controls.Add(this.labelDoublePocKeyB);
            this.tabPageDoublePoc.Controls.Add(this.labelDoublePocKeyA);
            this.tabPageDoublePoc.Controls.Add(this.textBoxDoublePocKeyB);
            this.tabPageDoublePoc.Controls.Add(this.textBoxDoublePocKeyA);
            this.tabPageDoublePoc.Controls.Add(this.richTextBoxDoublePocIn);
            this.tabPageDoublePoc.Location = new System.Drawing.Point(4, 25);
            this.tabPageDoublePoc.Name = "tabPageDoublePoc";
            this.tabPageDoublePoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoublePoc.Size = new System.Drawing.Size(768, 397);
            this.tabPageDoublePoc.TabIndex = 3;
            this.tabPageDoublePoc.Text = "Double Permutation of characters";
            this.tabPageDoublePoc.UseVisualStyleBackColor = true;
            // 
            // buttonDoublePocDecode
            // 
            this.buttonDoublePocDecode.Location = new System.Drawing.Point(500, 171);
            this.buttonDoublePocDecode.Name = "buttonDoublePocDecode";
            this.buttonDoublePocDecode.Size = new System.Drawing.Size(138, 28);
            this.buttonDoublePocDecode.TabIndex = 15;
            this.buttonDoublePocDecode.Text = "Расшифровать";
            this.buttonDoublePocDecode.UseVisualStyleBackColor = true;
            // 
            // buttonDoublePocEncode
            // 
            this.buttonDoublePocEncode.Location = new System.Drawing.Point(644, 171);
            this.buttonDoublePocEncode.Name = "buttonDoublePocEncode";
            this.buttonDoublePocEncode.Size = new System.Drawing.Size(120, 28);
            this.buttonDoublePocEncode.TabIndex = 14;
            this.buttonDoublePocEncode.Text = "Зашифровать";
            this.buttonDoublePocEncode.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDoublePocOut
            // 
            this.richTextBoxDoublePocOut.Location = new System.Drawing.Point(8, 205);
            this.richTextBoxDoublePocOut.Name = "richTextBoxDoublePocOut";
            this.richTextBoxDoublePocOut.ReadOnly = true;
            this.richTextBoxDoublePocOut.Size = new System.Drawing.Size(756, 187);
            this.richTextBoxDoublePocOut.TabIndex = 13;
            this.richTextBoxDoublePocOut.Text = "";
            // 
            // labelDoublePocKeyB
            // 
            this.labelDoublePocKeyB.AutoSize = true;
            this.labelDoublePocKeyB.Location = new System.Drawing.Point(245, 177);
            this.labelDoublePocKeyB.Name = "labelDoublePocKeyB";
            this.labelDoublePocKeyB.Size = new System.Drawing.Size(56, 17);
            this.labelDoublePocKeyB.TabIndex = 12;
            this.labelDoublePocKeyB.Text = "Ключ B";
            // 
            // labelDoublePocKeyA
            // 
            this.labelDoublePocKeyA.AutoSize = true;
            this.labelDoublePocKeyA.Location = new System.Drawing.Point(5, 177);
            this.labelDoublePocKeyA.Name = "labelDoublePocKeyA";
            this.labelDoublePocKeyA.Size = new System.Drawing.Size(56, 17);
            this.labelDoublePocKeyA.TabIndex = 11;
            this.labelDoublePocKeyA.Text = "Ключ A";
            // 
            // textBoxDoublePocKeyB
            // 
            this.textBoxDoublePocKeyB.Location = new System.Drawing.Point(307, 174);
            this.textBoxDoublePocKeyB.Name = "textBoxDoublePocKeyB";
            this.textBoxDoublePocKeyB.Size = new System.Drawing.Size(187, 22);
            this.textBoxDoublePocKeyB.TabIndex = 10;
            // 
            // textBoxDoublePocKeyA
            // 
            this.textBoxDoublePocKeyA.CausesValidation = false;
            this.textBoxDoublePocKeyA.Location = new System.Drawing.Point(67, 174);
            this.textBoxDoublePocKeyA.Name = "textBoxDoublePocKeyA";
            this.textBoxDoublePocKeyA.Size = new System.Drawing.Size(172, 22);
            this.textBoxDoublePocKeyA.TabIndex = 9;
            // 
            // richTextBoxDoublePocIn
            // 
            this.richTextBoxDoublePocIn.Location = new System.Drawing.Point(8, 4);
            this.richTextBoxDoublePocIn.Name = "richTextBoxDoublePocIn";
            this.richTextBoxDoublePocIn.Size = new System.Drawing.Size(756, 164);
            this.richTextBoxDoublePocIn.TabIndex = 8;
            this.richTextBoxDoublePocIn.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCaesar.ResumeLayout(false);
            this.tabPageCaesar.PerformLayout();
            this.tabPageAffineCaesar.ResumeLayout(false);
            this.tabPageAffineCaesar.PerformLayout();
            this.tabPageWhearstoneDoubleSquare.ResumeLayout(false);
            this.tabPageWhearstoneDoubleSquare.PerformLayout();
            this.tabPageDoublePoc.ResumeLayout(false);
            this.tabPageDoublePoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCaesar;
        private System.Windows.Forms.TabPage tabPageAffineCaesar;
        private System.Windows.Forms.TabPage tabPageWhearstoneDoubleSquare;
        private System.Windows.Forms.TabPage tabPageDoublePoc;
        private System.Windows.Forms.Button buttonAffineCaesarDecode;
        private System.Windows.Forms.Button buttonAffineCaesarEncode;
        private System.Windows.Forms.RichTextBox richTextBoxAffineCaesarOut;
        private System.Windows.Forms.Label labelAffineCaesarKeyB;
        private System.Windows.Forms.Label labelAffineCaesarKeyA;
        private System.Windows.Forms.TextBox textBoxAffineCaesarKeyN;
        private System.Windows.Forms.TextBox textBoxAffineCaesarKeyA;
        private System.Windows.Forms.RichTextBox richTextBoxAffineCaesarIn;
        private System.Windows.Forms.Button buttonWheatstoneDoubleSquareDecode;
        private System.Windows.Forms.Button buttonWheatstoneDoubleSquareEncode;
        private System.Windows.Forms.RichTextBox richTextBoxWheatstoneDoubleSquareOut;
        private System.Windows.Forms.Label labelWheatstoneDoubleSquareKeyB;
        private System.Windows.Forms.Label labelWheatstoneDoubleSquareKeyA;
        private System.Windows.Forms.TextBox textBoxWheatstoneDoubleSquareB;
        private System.Windows.Forms.TextBox textBoxWheatstoneDoubleSquareKeyA;
        private System.Windows.Forms.RichTextBox richTextBoxWheatstoneDoubleSquareIn;
        private System.Windows.Forms.Button buttonDoublePocDecode;
        private System.Windows.Forms.Button buttonDoublePocEncode;
        private System.Windows.Forms.RichTextBox richTextBoxDoublePocOut;
        private System.Windows.Forms.Label labelDoublePocKeyB;
        private System.Windows.Forms.Label labelDoublePocKeyA;
        private System.Windows.Forms.TextBox textBoxDoublePocKeyB;
        private System.Windows.Forms.TextBox textBoxDoublePocKeyA;
        private System.Windows.Forms.RichTextBox richTextBoxDoublePocIn;
        private System.Windows.Forms.Button buttonbuttonCaesarDecode;
        private System.Windows.Forms.Button buttonCaesarEncode;
        private System.Windows.Forms.RichTextBox richTextBoxCaesarOut;
        private System.Windows.Forms.Label labelCaesarKeyString;
        private System.Windows.Forms.Label labelCaesarKeyNum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textCaesarKeyNum;
        private System.Windows.Forms.RichTextBox richTextBoxCaesarIn;
    }
}

