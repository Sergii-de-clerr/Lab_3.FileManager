using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1._1._1
{
    public partial class Text_manager : Form
    {
        TextProcessor Tproc;

        public Text_manager(string path)
        {
            InitializeComponent();
            Tproc = new TextProcessor(path);
            ShowFileText();
        }

        public void ShowFileText()
        {
            BigtextBox.Text = Tproc.text;
        }

        private void OneWordbutton_Click(object sender, EventArgs e)
        {
            string Bigstring = BigtextBox.Text;
            List<string> Biglist = new List<string>();
            string word = string.Empty;
            bool Is_Prev_Prob = true;
            for (int i = 0; i < Bigstring.Length; i++)
            {
                if ((Bigstring[i] == ' ') && (Is_Prev_Prob == false))
                {
                    Biglist.Add(word);
                    word = string.Empty;
                    Is_Prev_Prob = true;
                }
                else if ((Bigstring[i] != ' '))
                {
                    if (((Bigstring[i] > 64) && (Bigstring[i] < 91)) || ((Bigstring[i] > 96) &&
                        (Bigstring[i] < 123)))
                    {
                            word += Bigstring[i];
                    }
                    Is_Prev_Prob = false;
                }
            }
            if (word.Length != 0)
            {
                Biglist.Add(word);
                word = string.Empty;
                Is_Prev_Prob = true;
            }
            Dictionary<string, int> BigDict = new Dictionary<string, int>();
            foreach (var f in Biglist)
            {
                if (Find_in_List(BigDict, f) == true)
                {
                    BigDict[f]++;
                }
                else
                {
                    BigDict.Add(f, 0);
                }
            }
            OnewordtextBox.Clear();
            foreach (var f in BigDict)
            {
                if (f.Value == 0)
                {
                    OnewordtextBox.Text += (f.Key + "\r\n");
                }
            }
        }

        private bool Find_in_List(Dictionary<string, int> BigDict, string word)
        {
            foreach (var f in BigDict)
            {
                if (f.Key == word)
                {
                    return true;
                }
            }
            return false;
        }

        private void Bigletter_button_Click(object sender, EventArgs e)
        {
            string Bigstring = BigtextBox.Text;
            string Bigletter_string = string.Empty;
            int i = 0;
            bool Is_Prev_Prob = true;
            //if ((Bigstring[i] > 64) && (Bigstring[i] < 91))
            //{

            //}
            for (; i < Bigstring.Length; i++)
            {
                if (Is_Prev_Prob == true)
                {
                    for (; (Bigstring[i] == ' ') && (i < Bigstring.Length); i++)
                    {
                        Bigletter_string += Bigstring[i];
                    }
                    if ((Bigstring[i] > 96) &&
                        (Bigstring[i] < 123) &&
                        (i < Bigstring.Length))
                    {
                        Bigletter_string += Convert.ToChar(Bigstring[i] - 32);
                    }
                    Is_Prev_Prob = false;
                }
                else
                {
                    if (Bigstring[i] == '.')
                    {
                        Is_Prev_Prob = true;
                    }
                    Bigletter_string += Bigstring[i];
                }
            }
            BigtextBox.Text = Bigletter_string;
        }

        private void зберегтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tproc.Save(BigtextBox.Text);
        }
    }
    public class TextProcessor
    {
        public string text;
        public string path;
        public TextProcessor(string tpath)
        {
            this.path = tpath;
            StreamReader file = System.IO.File.OpenText(path);
            text = file.ReadToEnd();
            file.Close();
        }
        public void Save(string to_save)
        {
            text = to_save;
            var file = new StreamWriter(path);
            file.WriteLine(to_save);
            file.Close();
        }
    }
}
