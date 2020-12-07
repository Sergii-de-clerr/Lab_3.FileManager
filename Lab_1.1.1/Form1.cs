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
using System.Xml.Linq;

namespace Lab_1._1._1
{
    public partial class Form1 : Form
    {
        private string leftcurdirpath;
        private string rightcurdirpath;
        private TreeNodeMouseClickEventArgs leftcurtreenode;
        private TreeNodeMouseClickEventArgs rightcurtreenode;
        Report Raport;
        public Form1()
        {
            InitializeComponent();
            CopyHtmlbutton.Visible = false;
            OpenHTMLbutton.Visible = false;
            DialogResult res = MessageBox.Show("Щоб обрати html натисніть Yes, щоб обрати txt натисніть No", "Звіт", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Raport = new HTMLReport();
            }
            else
            {
                Raport = new TXTReport();
            }
            Raport.Start();
            PopulateTreeView();
            this.LefttreeView.NodeMouseClick +=
                new TreeNodeMouseClickEventHandler(this.LefttreeView_NodeMouseClick);
        }

        private void PopulateTreeView()
        {
            TreeNode rootNode;
            leftcurdirpath = @"F:\C#";
            rightcurdirpath = @"F:\C#";
            DirectoryInfo info = new DirectoryInfo(leftcurdirpath);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                LefttreeView.Nodes.Add(rootNode);
            }
            info = new DirectoryInfo(rightcurdirpath);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                RighttreeView.Nodes.Add(rootNode);
            }
        }

        //private void PopulTreeView()
        //{
        //    TreeNode rootNode;
        //    DirectoryInfo info = new DirectoryInfo(leftcurdirpath);
        //    if (info.Exists)
        //    {
        //        rootNode = new TreeNode(info.Name);
        //        rootNode.Tag = info;
        //        GetDirectories(info.GetDirectories(), rootNode);
        //        LefttreeView.Nodes.Add(rootNode);
        //    }
        //    info = new DirectoryInfo(rightcurdirpath);
        //    if (info.Exists)
        //    {
        //        rootNode = new TreeNode(info.Name);
        //        rootNode.Tag = info;
        //        GetDirectories(info.GetDirectories(), rootNode);
        //        RighttreeView.Nodes.Add(rootNode);
        //    }
        //}

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e,
            ref string dirpath, ListBox LB)
        {
            TreeNode newSelected = e.Node;
            LB.Items.Clear();
            dirpath = Path.Combine(@"F:\", e.Node.FullPath);
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            //foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            //{
            //    item = new ListViewItem(dir.Name, 0);
            //    subItems = new ListViewItem.ListViewSubItem[]
            //        {new ListViewItem.ListViewSubItem(item, "Directory"),
            //         new ListViewItem.ListViewSubItem(item,
            //            dir.LastAccessTime.ToShortDateString())};
            //    item.SubItems.AddRange(subItems);
            //    LeftlistBox.Items.Add(item.Text);
            //}
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "File"),
                     new ListViewItem.ListViewSubItem(item,
                        file.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                LB.Items.Add(item.Text);
            }
        }

        private void LefttreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            leftcurtreenode = e;
            treeView_NodeMouseClick(sender, e, ref leftcurdirpath, LeftlistBox);
            Raport.SetTransition("Відкрито директорію " + leftcurdirpath);
        }

        private void LeftlistBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Open(Path.Combine(leftcurdirpath, LeftlistBox.SelectedItem.ToString()));
        }

        public void Open(string path)
        {
            Text_manager TM = new Text_manager(path);
            TM.Show();
        }

        private void RighttreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            rightcurtreenode = e;
            treeView_NodeMouseClick(sender, e, ref rightcurdirpath, RightlistBox);
            Raport.SetTransition("Відкрито директорію " + rightcurdirpath);
        }

        private void RightlistBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Open(Path.Combine(rightcurdirpath, RightlistBox.SelectedItem.ToString()));
        }

        private void Copy_button_Click(object sender, EventArgs e)
        {
            Copy_Button(sender, e);
        }

        private void Copy_Button(object sender, EventArgs e)
        {
            if ((RightlistBox.SelectedIndex == -1) && (LeftlistBox.SelectedIndex != -1))
            {
                string left = Path.Combine(leftcurdirpath, LeftlistBox.SelectedItem.ToString());
                string right = Path.Combine(rightcurdirpath, LeftlistBox.SelectedItem.ToString());
                File.Copy(Path.Combine(leftcurdirpath, LeftlistBox.SelectedItem.ToString()),
                    Path.Combine(rightcurdirpath, LeftlistBox.SelectedItem.ToString()));
                treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
                treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
                Raport.SetChange("Копіювання файлу з " + left + " в " + right);
            }
            else if ((RightlistBox.SelectedIndex != -1) && (LeftlistBox.SelectedIndex == -1))
            {
                string left = Path.Combine(leftcurdirpath, RightlistBox.SelectedItem.ToString());
                string right = Path.Combine(rightcurdirpath, RightlistBox.SelectedItem.ToString());
                File.Copy(Path.Combine(rightcurdirpath, RightlistBox.SelectedItem.ToString()),
                    Path.Combine(leftcurdirpath, RightlistBox.SelectedItem.ToString()));
                treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
                treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
                Raport.SetChange("Копіювання файлу з " + right + " в " + left);
            }
        }

        private void LeftlistBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (LeftlistBox.SelectedItems.Count == 0)
                return;
            RightlistBox.ClearSelected();
            string L = LeftlistBox.SelectedItem.ToString();
            if (L.IndexOf(".html") != -1)
            {
                CopyHtmlbutton.Visible = true;
                OpenHTMLbutton.Visible = true;
            }
            else
            {
                CopyHtmlbutton.Visible = false;
                OpenHTMLbutton.Visible = false;
            }
        }

        private void RightlistBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (RightlistBox.SelectedItems.Count == 0)
                return;
            LeftlistBox.ClearSelected();
            string L = RightlistBox.SelectedItem.ToString();
            if (L.IndexOf(".html") != -1)
            {
                CopyHtmlbutton.Visible = true;
                OpenHTMLbutton.Visible = true;
            }
            else
            {
                CopyHtmlbutton.Visible = false;
                OpenHTMLbutton.Visible = false;
            }
        }

        private void Copybutton_by_mask_Click(object sender, EventArgs e)
        {
            string inpath = string.Empty;
            string topath = string.Empty;
            bool was = false;
            if ((RightlistBox.SelectedIndex == -1) && (LeftlistBox.SelectedIndex != -1))
            {
                inpath = leftcurdirpath;
                topath = rightcurdirpath;
                was = true;
            }
            else if ((RightlistBox.SelectedIndex != -1) && (LeftlistBox.SelectedIndex == -1))
            {
                inpath = rightcurdirpath;
                topath = leftcurdirpath;
                was = true;
            }
            if (was == true)
            {
                Mask_ini CopyB = new Mask_ini(inpath, topath);
                CopyB.ShowDialog();
                treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
                treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
            }
        }

        public void CreateFile(string path)
        {
            if (path != null)
            {
                string new_path = Path.Combine(path, "Новий файл");
                int i = 1;
                string check = new_path + ".txt";
                while (System.IO.File.Exists(check))
                    check = new_path + "(" + i++.ToString() + ")" + ".txt";
                var file = System.IO.File.Create(check);
                file.Close();
            }
        }

        private void CreateTxt_button_Click(object sender, EventArgs e)
        {
            if ((RightlistBox.SelectedIndex == -1) && (LeftlistBox.SelectedIndex != -1))
            {
                CreateFile(leftcurdirpath);
            }
            else if ((RightlistBox.SelectedIndex != -1) && (LeftlistBox.SelectedIndex == -1))
            {
                CreateFile(rightcurdirpath);
            }
            treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
            treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
        }

        private void CopyHtmlbutton_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            string inpath = string.Empty;
            string topath = string.Empty;
            if ((RightlistBox.SelectedIndex == -1) && (LeftlistBox.SelectedIndex != -1))
            {
                path = Path.Combine(leftcurdirpath, LeftlistBox.SelectedItem.ToString());
                inpath = leftcurdirpath;
                topath = rightcurdirpath;
            }
            else if ((RightlistBox.SelectedIndex != -1) && (LeftlistBox.SelectedIndex == -1))
            {
                path = Path.Combine(rightcurdirpath, RightlistBox.SelectedItem.ToString());
                inpath = rightcurdirpath;
                topath = leftcurdirpath;
            }
            StreamReader file = System.IO.File.OpenText(path);
            var list = new List<string>();
            string text = file.ReadToEnd();
            int index = text.IndexOf("<img", 0);
            while (index != -1 && index < text.Length)
            {
                int index1 = text.IndexOf('"', text.IndexOf("src", index)) + 1;
                int index2 = text.IndexOf('"', index1) - index1;
                list.Add(text.Substring(index1, index2));
                index = text.IndexOf("<img", index + 1);
            }
            foreach (var l in list)
            {
                File.Copy(Path.Combine(inpath, l), Path.Combine(topath, l));
            }
            if ((RightlistBox.SelectedIndex == -1) && (LeftlistBox.SelectedIndex != -1))
            {
                string left = Path.Combine(leftcurdirpath, LeftlistBox.SelectedItem.ToString());
                string right = Path.Combine(rightcurdirpath, LeftlistBox.SelectedItem.ToString());
                File.Copy(Path.Combine(leftcurdirpath, LeftlistBox.SelectedItem.ToString()),
                    Path.Combine(rightcurdirpath, LeftlistBox.SelectedItem.ToString()));
                treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
                treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
                Raport.SetChange("Копіювання файлу разом з пов'язаними файли з " + left + " в " + right);
            }
            else if ((RightlistBox.SelectedIndex != -1) && (LeftlistBox.SelectedIndex == -1))
            {
                string left = Path.Combine(leftcurdirpath, RightlistBox.SelectedItem.ToString());
                string right = Path.Combine(rightcurdirpath, RightlistBox.SelectedItem.ToString());
                File.Copy(Path.Combine(rightcurdirpath, RightlistBox.SelectedItem.ToString()),
                    Path.Combine(leftcurdirpath, RightlistBox.SelectedItem.ToString()));
                treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
                treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
                Raport.SetChange("Копіювання файлу разом з пов'язаними файли з " + right + " в " + left);
            }
        }

        private void OpenHTMLbutton_Click(object sender, EventArgs e)
        {
            if ((RightlistBox.SelectedIndex == -1) && (LeftlistBox.SelectedIndex != -1))
            {
                System.Diagnostics.Process.Start(@"chrome.exe", Path.Combine(leftcurdirpath, LeftlistBox.SelectedItem.ToString()));
                CreateFile(leftcurdirpath);
            }
            else if ((RightlistBox.SelectedIndex != -1) && (LeftlistBox.SelectedIndex == -1))
            {
                System.Diagnostics.Process.Start(@"chrome.exe", Path.Combine(rightcurdirpath, RightlistBox.SelectedItem.ToString()));
                CreateFile(rightcurdirpath);
            }
        }

        private string Define_Path()
        {
            string path = string.Empty;
            if ((RightlistBox.SelectedIndex == -1) && (LeftlistBox.SelectedIndex != -1))
            {
                path = Path.Combine(leftcurdirpath, LeftlistBox.SelectedItem.ToString());
            }
            else if ((RightlistBox.SelectedIndex != -1) && (LeftlistBox.SelectedIndex == -1))
            {
                path = Path.Combine(rightcurdirpath, RightlistBox.SelectedItem.ToString());
            }
            return path;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Raport.Closing();
        }

        private void умоваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Варіант 19: 
Операції:
1) Копіювання та переміщення файлів формату HTML разом із пов&#39;язаними
файлами та виділення  слів, що вказані в &lt;TITLE&gt;.
2) Копіювання груп файлів, що мають особливості в іменах (напр. *.txt).
3) Знайти слова, які зустрічаються у тексті лише по одному разу.
4) Перетворити текст, що складається тільки з малих літер у текст, що
складається з великих і малих літер. Перша літера і літера після кінця речення - великі, інші
- малі.
5) З використанням шаблону «Будівельник» (Builder) реалізувати створення
звітів про роботу файлового менеджера в одному з обраних впри завантаженні програми
форматів (HTML чи текстовому)
");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Delete_Button(sender, e);
        }

        private void Delete_Button(object sender, EventArgs e)
        {
            string path = Define_Path();
            if (MessageBox.Show("Видалити?", "Підтвердити", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                System.IO.File.Delete(path);
            treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
            treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
        }

        private void Move_button_Click(object sender, EventArgs e)
        {
            string path = Define_Path();
            if (leftcurdirpath == rightcurdirpath)
            {
                return;
            }
            Copy_Button(sender, e);
            System.IO.File.Delete(path);
            treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
            treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
        }

        private void CreateDir_button_Click(object sender, EventArgs e)
        {
            if ((RightlistBox.SelectedIndex == -1) && (LeftlistBox.SelectedIndex != -1))
            {
                CreateDir(leftcurdirpath);
            }
            else if ((RightlistBox.SelectedIndex != -1) && (LeftlistBox.SelectedIndex == -1))
            {
                CreateDir(rightcurdirpath);
            }
            treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
            treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
        }

        private void CreateDir(string path)
        {
            if (path != null)
            {
                string new_path = Path.Combine(path, "Нова папка");
                int i = 1;
                string check = new_path;
                while (Directory.Exists(check))
                    check = new_path + "(" + i++.ToString() + ")";
                Directory.CreateDirectory(check);
            }
        }

        private void Rename_button_Click(object sender, EventArgs e)
        {
            if (Define_Path() != string.Empty)
            {
                Remame_Form CopyB = new Remame_Form(Define_Path());
                CopyB.ShowDialog();
                treeView_NodeMouseClick(sender, leftcurtreenode, ref leftcurdirpath, LeftlistBox);
                treeView_NodeMouseClick(sender, rightcurtreenode, ref rightcurdirpath, RightlistBox);
            }
        }
    }
}