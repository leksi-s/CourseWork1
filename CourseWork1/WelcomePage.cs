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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
            string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/dictionaries.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                dictionaries_listBox.Items.Add(s);
            }
        }
       
        private void label2_Click(object sender, EventArgs e) { }
        

        private void NewDictionaryButton_Click(object sender, EventArgs e)
        {
            NewDictionary newDictionary = new NewDictionary();
            this.Hide();
            newDictionary.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteDictionary deleteDictionary = new DeleteDictionary();
            this.Hide();
            deleteDictionary.Show();
            
        }

        public void dictionaries_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path2 = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedItem.txt";
            File.Delete(path2);
            using (StreamWriter file = new StreamWriter(path2, true))
            {
                file.Write(dictionaries_listBox.SelectedItem.ToString());
            }

            Dictionary dictionary = new Dictionary();
            this.Hide();
            dictionary.Show();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
