namespace ImageToASCII_Projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileButton = new Button();
            fileTextBox = new TextBox();
            genetareButton = new Button();
            outputTextBox = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            openButton = new Button();
            copyButton = new Button();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // fileButton
            // 
            fileButton.Location = new Point(16, 13);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(94, 29);
            fileButton.TabIndex = 0;
            fileButton.Text = "File";
            fileButton.UseVisualStyleBackColor = true;
            fileButton.Click += fileButton_Click;
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(116, 15);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.PlaceholderText = "Enter path or use File Button";
            fileTextBox.Size = new Size(331, 27);
            fileTextBox.TabIndex = 1;
            // 
            // genetareButton
            // 
            genetareButton.Location = new Point(16, 48);
            genetareButton.Name = "genetareButton";
            genetareButton.Size = new Size(94, 29);
            genetareButton.TabIndex = 2;
            genetareButton.Text = "Generate";
            genetareButton.UseVisualStyleBackColor = true;
            genetareButton.Click += genetareButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputTextBox.Location = new Point(116, 49);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(413, 133);
            outputTextBox.TabIndex = 3;
            outputTextBox.Text = "";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(453, 16);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(76, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // openButton
            // 
            openButton.Location = new Point(16, 83);
            openButton.Name = "openButton";
            openButton.Size = new Size(94, 29);
            openButton.TabIndex = 5;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(16, 118);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(94, 29);
            copyButton.TabIndex = 6;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(16, 153);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(545, 188);
            Controls.Add(saveButton);
            Controls.Add(copyButton);
            Controls.Add(openButton);
            Controls.Add(numericUpDown1);
            Controls.Add(outputTextBox);
            Controls.Add(genetareButton);
            Controls.Add(fileTextBox);
            Controls.Add(fileButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image To ASCII";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fileButton;
        private TextBox fileTextBox;
        private Button genetareButton;
        private RichTextBox outputTextBox;
        private NumericUpDown numericUpDown1;
        private Button openButton;
        private Button copyButton;
        private Button saveButton;
    }
}
