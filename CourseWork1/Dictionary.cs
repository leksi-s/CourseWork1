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
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
            string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedItem.txt";
            string selectedItem = File.ReadAllText(path);
            string[] elements = File.ReadAllLines($@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/{selectedItem}.txt");
            foreach (string element in elements)
            words_listBox.Items.Add(element);
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            Close();
        }

        private void NewWord_button_Click(object sender, EventArgs e)
        {
            NewWord newWord = new NewWord();
            newWord.Show();
            Close();
        }

        private void DeleteWord_button_Click(object sender, EventArgs e)
        {
            DeleteWord deleteWord = new DeleteWord();
            deleteWord.Show();
            Close();
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {

        }

        private void words_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedWord.txt";
            File.Delete(path);
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.Write(words_listBox.SelectedItem.ToString());
            }

            EditWord editWord = new EditWord();
            editWord.Show();
            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
