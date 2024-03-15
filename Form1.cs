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
       
        int RandomNumber(int from , int to)
        {
            return random.Next(from, to);
        }
        
        private void GenerateNumbers(int Count)
        {
            if (Count == 1)
            {
                txtGenerated.Text = RandomNumber(1, 9).ToString();
            } else if (Count == 2)
            {
                txtGenerated.Text = RandomNumber(10, 99).ToString();
            }
            else if (Count == 3)
            {
                txtGenerated.Text = RandomNumber(100, 999).ToString();
            }
            else if (Count == 4)
                txtGenerated.Text = random.Next(1000, 9999).ToString();
            else
            {
                txtGenerated.Text = random.Next(10000, 99999).ToString();
            }

        }
        private char GenerateCharacter()
        {
         return ((char)RandomNumber(65,90));
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
            return ((char)RandomNumber(33, 47));
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
        private void GenerateMixes(int Count)
        {
        }
        private void llCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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

            if (rbMix.Checked)
            {
                GenerateMixes(Count);
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
