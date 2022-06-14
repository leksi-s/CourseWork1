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
    public partial class DeleteDictionary : Form
    {
        public DeleteDictionary()
        {
            InitializeComponent();
            string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/dictionaries.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                dictionaries_comboBox.Items.Add(s);
            }
        }

        private void dictionaries_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletedictionary_button_Click(object sender, EventArgs e)
        {
            
                Language language = new Language();
                language.DeleteLanguage($"{dictionaries_comboBox.SelectedItem}");

                MessageBox.Show($"dictionary {dictionaries_comboBox.SelectedItem} is deleted.");
                WelcomePage welcomePage = new WelcomePage();
                welcomePage.Show();
                this.Close();

            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            Close();
        }
    }
}
