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
    public partial class Remame_Form : Form
    {
        string path;
        string rename = string.Empty;
        public Remame_Form(string tPath)
        {
            InitializeComponent();
            Filename_label.Text = Path.GetFileName(tPath);
            path = tPath;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rename = textBox1.Text;
        }

        private void Rename_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                DialogResult r = MessageBox.Show("Хочете перейти назад до файлового менеджера?", "Ви нічого не ввели", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Remame_Form.ActiveForm.Close();
                }
                else
                {
                    return;
                }
            }
            string father = (path + "\\").Substring(0, path.LastIndexOf("\\"));
            string new_path = System.IO.Path.Combine(father, rename);
            string check = new_path;
            int i = 1;
            //string father = (Path + "\\").Substring(0, Path.LastIndexOf("\\"));//отримуємо шлях до батька
            if (!System.IO.File.Exists(new_path))
            {
                if (father.EndsWith(":")) father += "\\";
                rename += ".txt";
                if (!System.IO.File.Exists(System.IO.Path.Combine(father, rename)))
                    System.IO.File.Move(path, System.IO.Path.Combine(father, rename));
            }
            else
            {
                while (System.IO.File.Exists(check))
                    check = new_path + "(" + i++.ToString() + ")" + ".txt";
                System.IO.File.Move(path, System.IO.Path.Combine(father, check));
                //file.Close();
            }
            Remame_Form.ActiveForm.Close();
        }
    }
}
