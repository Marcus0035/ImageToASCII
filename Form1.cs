using System.Diagnostics;
using System.Windows.Forms;

namespace ImageToASCII_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Choose File To Convert";      //nazev v zahlavi
            openFileDialog1.ShowDialog();                          //otevre file explorer

            if (openFileDialog1 != null)        //kontrola zda uzivael zadal aspon neco
            {
                fileTextBox.Clear();
                fileTextBox.Text = openFileDialog1.FileName;        //smazani a nastaveni do textboxu
            }
            else
            {
                MessageBox.Show("Select existing file");
            }
        }

        private void genetareButton_Click(object sender, EventArgs e)
        {
            if (fileTextBox.Text.EndsWith(".jpg") && File.Exists(fileTextBox.Text))     //kontrola jpg a jestli existuje
            {
                string image = Funkce.Program(fileTextBox.Text, decimal.ToInt32(numericUpDown1.Value));

                outputTextBox.Clear();
                outputTextBox.Text = image;
            }
            else
            {
                MessageBox.Show("Please select existing .jpg file", "Error");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(outputTextBox.Text))
            {
                StreamWriter writer = new StreamWriter("OutputFile.txt");
                writer.Write(outputTextBox.Text);
                writer.Close();

                Process.Start("Notepad.Exe", "OutputFile.txt");
            }
            else
            {
                MessageBox.Show("Please select file first");
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(outputTextBox.Text))
            {
                Clipboard.SetText(outputTextBox.Text);
                MessageBox.Show("Text was copied", "Copy");
            }
            else
            {
                MessageBox.Show("Please select file first");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(outputTextBox.Text))
            {
                StreamWriter writer = new StreamWriter("OutputFile.txt");
                writer.Write(outputTextBox.Text);
                writer.Close();

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy("OutputFile.txt" ,saveFileDialog.FileName + ".txt", true);     //true aby to pripadne prepsalo soubor
                }

                MessageBox.Show("Sucess save");
            }
            else
            {
                MessageBox.Show("Empty textbox");
            }
        }
    }
}
