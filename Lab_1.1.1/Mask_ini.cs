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
    public partial class Mask_ini : Form
    {
        string inpath;
        string topath;
        public static string[] Getfiles;
        public Mask_ini(string INpath, string TOpath)
        {
            InitializeComponent();
            inpath = INpath;
            topath = TOpath;
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            if (MasktextBox.Text == "")
            {
                DialogResult r = MessageBox.Show("Хочете перейти назад до файлового менеджера?", "Ви нічого не ввели", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Mask_ini.ActiveForm.Close();
                }
            }
            string mask = MasktextBox.Text;
            Getfiles = Directory.GetFiles(inpath, mask);
            foreach (var l in Getfiles)
            {
                Getfiles_textBox.Text += (l + "\r\n");
            }
            //DirectoryInfo curdir = new DirectoryInfo("");
        }

        private void Copy_m_button_Click(object sender, EventArgs e)
        {
        }

        private void Copy_m_button_Click_1(object sender, EventArgs e)
        {
            if (MasktextBox.Text == "")
            {
                DialogResult re = MessageBox.Show("Хочете перейти назад до файлового менеджера?", "Ви нічого не ввели", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    Mask_ini.ActiveForm.Close();
                }
            }
            foreach (var l in Getfiles)
            {
                File.Copy(l, Path.Combine(topath, Path.GetFileName(l)));
            }
            DialogResult r = MessageBox.Show("Хочете перейти назад до файлового менеджера?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Mask_ini.ActiveForm.Close();
            }
        }
    }
}
