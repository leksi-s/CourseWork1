using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseWork1
{
    internal class Language
    {
        public void AddLanguage(string dictionary)
        {
            using (StreamWriter file = new StreamWriter(@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/dictionaries.txt", true))
            {
                file.WriteLine(dictionary);
            }
            string path = $@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/{dictionary}.txt";

            FileStream fs = File.Create(path);         
        }

        public void DeleteLanguage(string dictionary)
        {
            string del = $"{dictionary}";
            File.Delete($@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/{del}.txt");
            string path = $@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/dictionaries.txt";
            string path2 = $@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/res.txt";

            string[] elements = File.ReadAllLines(path);
            foreach (string element in elements)
            {
                if (element.Contains(del)) { }
                else
                {
                    using (StreamWriter file = new StreamWriter(path2, true))
                    {
                        file.WriteLine(element);
                    }

                }
            }
            File.WriteAllText(path, string.Empty);
            string[] newelements = File.ReadAllLines(path2);
            foreach (string element in newelements)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                    file.WriteLine(element);
            }
            File.WriteAllText(path2, string.Empty);
        }
    }
}
