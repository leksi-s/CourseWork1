using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork1
{
    public partial class NewWord : Form
    {
        public NewWord()
        {
            InitializeComponent();

        }
        
        private void back_button_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.Show();
            Close();
        }

        public void NewWord_button_Click(object sender, EventArgs e)
        {
            if (Word_textBox.Text.ToString() == "" || Translation_textBox.Text.ToString()=="")
                MessageBox.Show("input the word!");
            else
            {
                Word word = new Word();
                word.AddWord($"{Word_textBox.Text}", $"{Translation_textBox.Text}");

                MessageBox.Show($"new word is added!");
            }
        }

        private void NewWord_Load(object sender, EventArgs e)
        {

        }

        private void Word_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
