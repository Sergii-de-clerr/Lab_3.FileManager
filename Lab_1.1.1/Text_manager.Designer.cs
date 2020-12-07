namespace Lab_1._1._1
{
    partial class Text_manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BigtextBox = new System.Windows.Forms.TextBox();
            this.OneWordbutton = new System.Windows.Forms.Button();
            this.OnewordtextBox = new System.Windows.Forms.TextBox();
            this.Bigletter_button = new System.Windows.Forms.Button();
            this.TextmenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TextmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BigtextBox
            // 
            this.BigtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigtextBox.Location = new System.Drawing.Point(330, 108);
            this.BigtextBox.Multiline = true;
            this.BigtextBox.Name = "BigtextBox";
            this.BigtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BigtextBox.Size = new System.Drawing.Size(1688, 827);
            this.BigtextBox.TabIndex = 0;
            // 
            // OneWordbutton
            // 
            this.OneWordbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneWordbutton.Location = new System.Drawing.Point(12, 47);
            this.OneWordbutton.Name = "OneWordbutton";
            this.OneWordbutton.Size = new System.Drawing.Size(312, 55);
            this.OneWordbutton.TabIndex = 2;
            this.OneWordbutton.Text = "Знайти слова, які трапляються по одному разу";
            this.OneWordbutton.UseVisualStyleBackColor = true;
            this.OneWordbutton.Click += new System.EventHandler(this.OneWordbutton_Click);
            // 
            // OnewordtextBox
            // 
            this.OnewordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OnewordtextBox.Location = new System.Drawing.Point(12, 108);
            this.OnewordtextBox.Multiline = true;
            this.OnewordtextBox.Name = "OnewordtextBox";
            this.OnewordtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OnewordtextBox.Size = new System.Drawing.Size(312, 827);
            this.OnewordtextBox.TabIndex = 3;
            // 
            // Bigletter_button
            // 
            this.Bigletter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bigletter_button.Location = new System.Drawing.Point(330, 47);
            this.Bigletter_button.Name = "Bigletter_button";
            this.Bigletter_button.Size = new System.Drawing.Size(312, 55);
            this.Bigletter_button.TabIndex = 4;
            this.Bigletter_button.Text = "Перетворити слова з малих на початку речення на слова з великої літери";
            this.Bigletter_button.UseVisualStyleBackColor = true;
            this.Bigletter_button.Click += new System.EventHandler(this.Bigletter_button_Click);
            // 
            // TextmenuStrip
            // 
            this.TextmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.TextmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TextmenuStrip.Name = "TextmenuStrip";
            this.TextmenuStrip.Size = new System.Drawing.Size(2030, 24);
            this.TextmenuStrip.TabIndex = 10;
            this.TextmenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem1
            // 
            this.зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            this.зберегтиToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.зберегтиToolStripMenuItem1.Text = "Зберегти";
            this.зберегтиToolStripMenuItem1.Click += new System.EventHandler(this.зберегтиToolStripMenuItem1_Click);
            // 
            // Text_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2030, 947);
            this.Controls.Add(this.TextmenuStrip);
            this.Controls.Add(this.Bigletter_button);
            this.Controls.Add(this.OnewordtextBox);
            this.Controls.Add(this.OneWordbutton);
            this.Controls.Add(this.BigtextBox);
            this.Name = "Text_manager";
            this.Text = "Текстовий редактор";
            this.TextmenuStrip.ResumeLayout(false);
            this.TextmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BigtextBox;
        private System.Windows.Forms.Button OneWordbutton;
        private System.Windows.Forms.TextBox OnewordtextBox;
        private System.Windows.Forms.Button Bigletter_button;
        private System.Windows.Forms.MenuStrip TextmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem1;
    }
}