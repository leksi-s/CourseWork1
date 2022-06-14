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
    public partial class EditWord : Form
    {
        string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedWord.txt";
        public EditWord()
        {
            InitializeComponent();
            string selectedItem = File.ReadAllText(path);

            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                edit_textBox.Text=s;
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.Show();
            this.Close();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            if (edit_textBox.Text.ToString() == "")
                MessageBox.Show("input the word!");

            else
            {
                string change = edit_textBox.Text;
                Word word = new Word();
                word.EditWord(change);

                MessageBox.Show("the word is changed!");
                Dictionary dictionary = new Dictionary();
                dictionary.Show();
                this.Close();
            }
        }
    }
}
