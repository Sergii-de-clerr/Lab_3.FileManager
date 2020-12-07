namespace Lab_1._1._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.умоваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LefttreeView = new System.Windows.Forms.TreeView();
            this.imageList_for_icon = new System.Windows.Forms.ImageList(this.components);
            this.LeftlistBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RighttreeView = new System.Windows.Forms.TreeView();
            this.RightlistBox = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Copy_button = new System.Windows.Forms.Button();
            this.Copybutton_by_mask = new System.Windows.Forms.Button();
            this.CreateTxt_button = new System.Windows.Forms.Button();
            this.CopyHtmlbutton = new System.Windows.Forms.Button();
            this.OpenHTMLbutton = new System.Windows.Forms.Button();
            this.Move_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.CreateDir_button = new System.Windows.Forms.Button();
            this.Rename_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.допомогаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2097, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.умоваToolStripMenuItem});
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // умоваToolStripMenuItem
            // 
            this.умоваToolStripMenuItem.Name = "умоваToolStripMenuItem";
            this.умоваToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.умоваToolStripMenuItem.Text = "Умова";
            this.умоваToolStripMenuItem.Click += new System.EventHandler(this.умоваToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ліва";
            // 
            // LefttreeView
            // 
            this.LefttreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LefttreeView.ImageIndex = 0;
            this.LefttreeView.ImageList = this.imageList_for_icon;
            this.LefttreeView.Location = new System.Drawing.Point(12, 73);
            this.LefttreeView.Name = "LefttreeView";
            this.LefttreeView.SelectedImageIndex = 0;
            this.LefttreeView.Size = new System.Drawing.Size(395, 916);
            this.LefttreeView.TabIndex = 2;
            this.LefttreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.LefttreeView_NodeMouseClick);
            // 
            // imageList_for_icon
            // 
            this.imageList_for_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_for_icon.ImageStream")));
            this.imageList_for_icon.Tag = "";
            this.imageList_for_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_for_icon.Images.SetKeyName(0, "folder.jpg");
            this.imageList_for_icon.Images.SetKeyName(1, "text.png");
            // 
            // LeftlistBox
            // 
            this.LeftlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftlistBox.FormattingEnabled = true;
            this.LeftlistBox.ItemHeight = 16;
            this.LeftlistBox.Location = new System.Drawing.Point(413, 73);
            this.LeftlistBox.Name = "LeftlistBox";
            this.LeftlistBox.Size = new System.Drawing.Size(623, 916);
            this.LeftlistBox.TabIndex = 3;
            this.LeftlistBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeftlistBox_MouseClick);
            this.LeftlistBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LeftlistBox_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1058, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Права";
            // 
            // RighttreeView
            // 
            this.RighttreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RighttreeView.ImageIndex = 0;
            this.RighttreeView.ImageList = this.imageList_for_icon;
            this.RighttreeView.Location = new System.Drawing.Point(1061, 73);
            this.RighttreeView.Name = "RighttreeView";
            this.RighttreeView.SelectedImageIndex = 0;
            this.RighttreeView.Size = new System.Drawing.Size(395, 916);
            this.RighttreeView.TabIndex = 5;
            this.RighttreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.RighttreeView_NodeMouseClick);
            // 
            // RightlistBox
            // 
            this.RightlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightlistBox.FormattingEnabled = true;
            this.RightlistBox.ItemHeight = 16;
            this.RightlistBox.Location = new System.Drawing.Point(1462, 73);
            this.RightlistBox.Name = "RightlistBox";
            this.RightlistBox.Size = new System.Drawing.Size(623, 916);
            this.RightlistBox.TabIndex = 6;
            this.RightlistBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RightlistBox_MouseClick);
            this.RightlistBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RightlistBox_MouseDoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1274);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // Copy_button
            // 
            this.Copy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copy_button.Location = new System.Drawing.Point(12, 1040);
            this.Copy_button.Name = "Copy_button";
            this.Copy_button.Size = new System.Drawing.Size(395, 120);
            this.Copy_button.TabIndex = 8;
            this.Copy_button.Text = "Копіювати";
            this.Copy_button.UseVisualStyleBackColor = true;
            this.Copy_button.Click += new System.EventHandler(this.Copy_button_Click);
            // 
            // Copybutton_by_mask
            // 
            this.Copybutton_by_mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copybutton_by_mask.Location = new System.Drawing.Point(12, 1166);
            this.Copybutton_by_mask.Name = "Copybutton_by_mask";
            this.Copybutton_by_mask.Size = new System.Drawing.Size(395, 120);
            this.Copybutton_by_mask.TabIndex = 9;
            this.Copybutton_by_mask.Text = "Копіювання файлів \r\nпо масці";
            this.Copybutton_by_mask.UseVisualStyleBackColor = true;
            this.Copybutton_by_mask.Click += new System.EventHandler(this.Copybutton_by_mask_Click);
            // 
            // CreateTxt_button
            // 
            this.CreateTxt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTxt_button.Location = new System.Drawing.Point(814, 1166);
            this.CreateTxt_button.Name = "CreateTxt_button";
            this.CreateTxt_button.Size = new System.Drawing.Size(395, 120);
            this.CreateTxt_button.TabIndex = 10;
            this.CreateTxt_button.Text = "Створити текстовий файл";
            this.CreateTxt_button.UseVisualStyleBackColor = true;
            this.CreateTxt_button.Click += new System.EventHandler(this.CreateTxt_button_Click);
            // 
            // CopyHtmlbutton
            // 
            this.CopyHtmlbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyHtmlbutton.Location = new System.Drawing.Point(1215, 1166);
            this.CopyHtmlbutton.Name = "CopyHtmlbutton";
            this.CopyHtmlbutton.Size = new System.Drawing.Size(395, 120);
            this.CopyHtmlbutton.TabIndex = 11;
            this.CopyHtmlbutton.Text = "Копіювання HTML файлу разом з пов\'язаними файлами";
            this.CopyHtmlbutton.UseVisualStyleBackColor = true;
            this.CopyHtmlbutton.Click += new System.EventHandler(this.CopyHtmlbutton_Click);
            // 
            // OpenHTMLbutton
            // 
            this.OpenHTMLbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenHTMLbutton.Location = new System.Drawing.Point(1616, 1166);
            this.OpenHTMLbutton.Name = "OpenHTMLbutton";
            this.OpenHTMLbutton.Size = new System.Drawing.Size(395, 120);
            this.OpenHTMLbutton.TabIndex = 12;
            this.OpenHTMLbutton.Text = "Відкрити HTML файл\r\n";
            this.OpenHTMLbutton.UseVisualStyleBackColor = true;
            this.OpenHTMLbutton.Click += new System.EventHandler(this.OpenHTMLbutton_Click);
            // 
            // Move_button
            // 
            this.Move_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Move_button.Location = new System.Drawing.Point(413, 1166);
            this.Move_button.Name = "Move_button";
            this.Move_button.Size = new System.Drawing.Size(395, 120);
            this.Move_button.TabIndex = 13;
            this.Move_button.Text = "Перемістити";
            this.Move_button.UseVisualStyleBackColor = true;
            this.Move_button.Click += new System.EventHandler(this.Move_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.Transparent;
            this.Delete_button.CausesValidation = false;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(413, 1040);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(395, 120);
            this.Delete_button.TabIndex = 14;
            this.Delete_button.Text = "Видалити";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // CreateDir_button
            // 
            this.CreateDir_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDir_button.Location = new System.Drawing.Point(814, 1040);
            this.CreateDir_button.Name = "CreateDir_button";
            this.CreateDir_button.Size = new System.Drawing.Size(395, 120);
            this.CreateDir_button.TabIndex = 15;
            this.CreateDir_button.Text = "Створити папку";
            this.CreateDir_button.UseVisualStyleBackColor = true;
            this.CreateDir_button.Click += new System.EventHandler(this.CreateDir_button_Click);
            // 
            // Rename_button
            // 
            this.Rename_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rename_button.Location = new System.Drawing.Point(1215, 1040);
            this.Rename_button.Name = "Rename_button";
            this.Rename_button.Size = new System.Drawing.Size(395, 120);
            this.Rename_button.TabIndex = 16;
            this.Rename_button.Text = "Перейменування";
            this.Rename_button.UseVisualStyleBackColor = true;
            this.Rename_button.Click += new System.EventHandler(this.Rename_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2097, 1298);
            this.Controls.Add(this.Rename_button);
            this.Controls.Add(this.CreateDir_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Move_button);
            this.Controls.Add(this.OpenHTMLbutton);
            this.Controls.Add(this.CopyHtmlbutton);
            this.Controls.Add(this.CreateTxt_button);
            this.Controls.Add(this.Copybutton_by_mask);
            this.Controls.Add(this.Copy_button);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.RightlistBox);
            this.Controls.Add(this.RighttreeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeftlistBox);
            this.Controls.Add(this.LefttreeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Файловий менеджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView LefttreeView;
        private System.Windows.Forms.ImageList imageList_for_icon;
        private System.Windows.Forms.ListBox LeftlistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView RighttreeView;
        private System.Windows.Forms.ListBox RightlistBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button Copy_button;
        private System.Windows.Forms.Button Copybutton_by_mask;
        private System.Windows.Forms.Button CreateTxt_button;
        private System.Windows.Forms.Button CopyHtmlbutton;
        private System.Windows.Forms.Button OpenHTMLbutton;
        private System.Windows.Forms.ToolStripMenuItem умоваToolStripMenuItem;
        private System.Windows.Forms.Button Move_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button CreateDir_button;
        private System.Windows.Forms.Button Rename_button;
    }
}

