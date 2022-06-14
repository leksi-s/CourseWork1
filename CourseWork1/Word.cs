using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseWork1
{
    internal class Word
    {
        public void AddWord(string word, string translation)
        {
            string word_translation = $"{word}-{translation}";

            string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedItem.txt";
            string selectedItem = File.ReadAllText(path);

            using (StreamWriter file = new StreamWriter($@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/{selectedItem}.txt", true))
            {
                file.WriteLine(word_translation);
            }
        }

        public void DeleteWord(string delword)
        {
            string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedItem.txt";
            string selectedItem = File.ReadAllText(path);
            string path1 = $@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/{selectedItem}.txt";
            string path2 = $@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/res.txt";

            string[] elements = File.ReadAllLines(path1);
            
            foreach (string element in elements)
            {
                if (element.Contains(delword)) { }
                else
                {
                    using (StreamWriter file = new StreamWriter(path2, true))
                    {
                        file.WriteLine(element);
                    }

                }
            }
            File.WriteAllText(path1, string.Empty);
            string[] newelements = File.ReadAllLines(path2);
            foreach (string element in newelements)
            {
                using (StreamWriter file = new StreamWriter(path1, true))
                    file.WriteLine(element);
            }
            File.WriteAllText(path2, string.Empty); 
        }

        public void EditWord(string change)
        {
            string path = "C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedWord.txt";

            string selectedDictionary = File.ReadAllText("C:/Users/Admin/source/repos/CourseWork1/CourseWork1/selectedItem.txt");
            string selectedWord = File.ReadAllText(path);
            string path1 = $@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/{selectedDictionary}.txt";
            string path2 = $@"C:/Users/Admin/source/repos/CourseWork1/CourseWork1/res.txt";

            string[] elements = File.ReadAllLines(path1);
            string delword = $"{selectedWord}";
            foreach (string element in elements)
            {
                if (element.Contains(delword)) { }
                else
                {
                    using (StreamWriter file = new StreamWriter(path2, true))
                    {
                        file.WriteLine(element);
                    }

                }
            }
            File.WriteAllText(path1, string.Empty);
            string[] newelements = File.ReadAllLines(path2);
            foreach (string element in newelements)
            {
                using (StreamWriter file = new StreamWriter(path1, true))
                    file.WriteLine(element);
            }
            File.WriteAllText(path2, string.Empty);
            using (StreamWriter file = new StreamWriter(path1, true))
                file.WriteLine(change);
        }
    }
}
