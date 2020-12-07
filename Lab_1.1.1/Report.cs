using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._1._1
{
    class Report
    {
        public Report() { }
        public virtual void Start() { }
        public virtual void SetChange(string text) { }
        public virtual void SetTransition(string text) { }
        public virtual void SetError(string text) { }
        public virtual void Closing() { }
    }

    class TXTReport : Report
    {
        string text = string.Empty;
        public override void Start()
        {
            text += ("Звіт про роботу файлового менеджера. " + DateTime.Now + '\n');
        }
        public override void SetChange(string ttext)
        {
            text += (DateTime.Now + "Зміни. " + ttext + '\n');
        }
        public override void SetTransition(string ttext)
        {
            text += (DateTime.Now + "Перехід. " + ttext + '\n');
        }
        public override void SetError(string ttext)
        {
            text += (DateTime.Now + "Помилка. " + ttext + '\n');
        }
        
        public override void Closing()
        {
            string Name = "Звіт" + DateTime.Now.ToString();
            Name = Name.Replace(":", ".");
            string new_path = Path.Combine(@"F:\Reports", Name);
            int i = 1;
            string check = new_path + ".txt";
            while (System.IO.File.Exists(check))
                check = new_path + "(" + i++.ToString() + ")" + ".txt";
            var file = System.IO.File.Create(check);
            file.Close();
            text += ("Дякую! " + DateTime.Now);
            var ffile = new StreamWriter(check);
            ffile.WriteLine(text);
            ffile.Close();
        }
    }
    //----------------------------------------------
    class HTMLReport : Report
    {
        string text = string.Empty;
        public override void Start()
        {
            text += "<HTML><BODY>\r\n";
            text += ("<H1>Звіт про роботу файлового менеджера. " + DateTime.Now + "</H1>\n");
        }
        public override void SetChange(string ttext)
        {
            text += ("<p>" + DateTime.Now + "Зміни. " + ttext + "</p>\n");
        }
        public override void SetTransition(string ttext)
        {
            text += ("<p>" + DateTime.Now + "Перехід. " + ttext + "</p>\n");
        }
        public override void SetError(string ttext)
        {
            text += ("<p>" + DateTime.Now + "Помилка. " + ttext + "</p>\n");
        }

        public override void Closing()
        {
            string Name = "Звіт" + DateTime.Now.ToString();
            Name = Name.Replace(":", ".");
            string new_path = Path.Combine(@"F:\Reports", Name);
            int i = 1;
            string check = new_path + ".html";
            while (System.IO.File.Exists(check))
                check = new_path + "(" + i++.ToString() + ")" + ".txt";
            var file = System.IO.File.Create(check);
            file.Close();
            text += ("<p><i>Дякую! " + DateTime.Now + "</i></p>\n");
            text += "</HTML></BODY>\r\n";
            var ffile = new StreamWriter(check);
            ffile.WriteLine(text);
            ffile.Close();
        }
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