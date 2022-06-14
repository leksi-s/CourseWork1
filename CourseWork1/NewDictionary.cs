using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CourseWork1
{
    public partial class NewDictionary : Form
    {
        public NewDictionary()
        {
            InitializeComponent();
        }

        

        private void NewDictionary_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dictionary.Text.ToString() == "")
                MessageBox.Show("input the name for your dictionary!");
            else
            {
                Language language = new Language();
                language.AddLanguage($"{dictionary.Text}");

                MessageBox.Show("new dictionary is added!");//стерти

                WelcomePage welcomePage = new WelcomePage();
                welcomePage.Show();
                this.Close();
            }
           
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            Close();
        }
    }
}
