namespace Generate_Numbers_Letters_Special_Characters
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.rbSpecialCharacters = new System.Windows.Forms.RadioButton();
            this.rbNumbers = new System.Windows.Forms.RadioButton();
            this.rbLetters = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.llCopy = new System.Windows.Forms.LinkLabel();
            this.txtGenerated = new System.Windows.Forms.TextBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(249, 432);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 54);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(480, 432);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 54);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.rbSpecialCharacters);
            this.gbInfo.Controls.Add(this.rbNumbers);
            this.gbInfo.Controls.Add(this.rbLetters);
            this.gbInfo.Controls.Add(this.numericUpDown1);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Location = new System.Drawing.Point(12, 247);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(339, 161);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            // 
            // rbSpecialCharacters
            // 
            this.rbSpecialCharacters.AutoSize = true;
            this.rbSpecialCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSpecialCharacters.Location = new System.Drawing.Point(20, 116);
            this.rbSpecialCharacters.Name = "rbSpecialCharacters";
            this.rbSpecialCharacters.Size = new System.Drawing.Size(173, 24);
            this.rbSpecialCharacters.TabIndex = 5;
            this.rbSpecialCharacters.Text = "Special Characters";
            this.rbSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // rbNumbers
            // 
            this.rbNumbers.AutoSize = true;
            this.rbNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumbers.Location = new System.Drawing.Point(209, 75);
            this.rbNumbers.Name = "rbNumbers";
            this.rbNumbers.Size = new System.Drawing.Size(98, 24);
            this.rbNumbers.TabIndex = 4;
            this.rbNumbers.Text = "Numbers";
            this.rbNumbers.UseVisualStyleBackColor = true;
            // 
            // rbLetters
            // 
            this.rbLetters.AutoSize = true;
            this.rbLetters.Checked = true;
            this.rbLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLetters.Location = new System.Drawing.Point(20, 75);
            this.rbLetters.Name = "rbLetters";
            this.rbLetters.Size = new System.Drawing.Size(83, 24);
            this.rbLetters.TabIndex = 3;
            this.rbLetters.TabStop = true;
            this.rbLetters.Text = "Letters";
            this.rbLetters.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(187, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number Of Digits:";
            // 
            // llCopy
            // 
            this.llCopy.AutoSize = true;
            this.llCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llCopy.Location = new System.Drawing.Point(299, 175);
            this.llCopy.Name = "llCopy";
            this.llCopy.Size = new System.Drawing.Size(52, 22);
            this.llCopy.TabIndex = 3;
            this.llCopy.TabStop = true;
            this.llCopy.Text = "Copy";
            this.llCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCopy_LinkClicked);
            // 
            // txtGenerated
            // 
            this.txtGenerated.Location = new System.Drawing.Point(12, 12);
            this.txtGenerated.Multiline = true;
            this.txtGenerated.Name = "txtGenerated";
            this.txtGenerated.ReadOnly = true;
            this.txtGenerated.Size = new System.Drawing.Size(339, 141);
            this.txtGenerated.TabIndex = 4;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(64, 175);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 54);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 508);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.txtGenerated);
            this.Controls.Add(this.llCopy);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.RadioButton rbNumbers;
        private System.Windows.Forms.RadioButton rbLetters;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llCopy;
        private System.Windows.Forms.TextBox txtGenerated;
        private System.Windows.Forms.RadioButton rbSpecialCharacters;
        private System.Windows.Forms.Button btnOptions;
    }
}

