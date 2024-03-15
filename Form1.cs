using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Generate_Numbers_Letters_Special_Characters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Random random = new Random();
       
        private void GenerateNumbers(int Count)
        {
            int minRange = (int)Math.Pow(10, Count - 1);
            int maxRange = (int)Math.Pow(10, Count) - 1;
            txtGenerated.Text = random.Next(minRange, maxRange).ToString();
        }
        private char GenerateCharacter()
        {
         return ((char)random.Next(65,90));
        }
        private void GenerateCharacters(int Count)
        {
            string Word = "";
            for (int i = 1;i <= Count; i++)
            {
              Word += GenerateCharacter();
            }
            txtGenerated.Text = Word;
        }
        private char GenerateSpecialCharacter()
        {
            return ((char)random.Next(33, 47));
        }
        private void GenerateSpecialCharacters(int Count)
        {
            string SpecialCharacters = "";
            for (int i = 1; i <= Count; i++)
            {
                SpecialCharacters += GenerateSpecialCharacter();
            }
            txtGenerated.Text = SpecialCharacters;
        }
        private void llCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGenerated.Text))
            {
                MessageBox.Show("There is no Text to Copy", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Clipboard.SetText(txtGenerated.Text);
            MessageBox.Show("The Text has been Copied","Copied",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int Count = (int) numericUpDown1.Value;
            if (rbNumbers.Checked)
            {
                GenerateNumbers(Count);
            }

            if (rbLetters.Checked)
            {
                GenerateCharacters(Count);
            }

            if (rbSpecialCharacters.Checked)
            {
                GenerateSpecialCharacters(Count);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGenerated.Text = "";
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            if (gbInfo.Visible)
                gbInfo.Visible = false;
            else
                gbInfo.Visible = true;
        }
    }
}
