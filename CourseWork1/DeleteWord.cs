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
    public partial class DeleteWord : Form
    {
        string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedItem.txt";
        
        public DeleteWord()
        {
            InitializeComponent();
            string selectedItem = File.ReadAllText(path);
            string[] elements = File.ReadAllLines($@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/{selectedItem}.txt");
            //тут має бути посилання через {welcomePage.dictionaries.SelectedValue} на обраний словник
            foreach (string element in elements)
                words_listBox.Items.Add(element);
        }

        private void words_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
          
                Word word = new Word();
                string delword = $"{words_listBox.SelectedItem}";
                word.DeleteWord(delword);

                MessageBox.Show($"the word \'{words_listBox.SelectedItem}\' is deleted!");

                this.Refresh();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Dictionary dictionary= new Dictionary();
            dictionary.Show();
            Close();
        }
    }
}
