namespace Lab_1._1._1
{
    partial class Mask_ini
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
            this.label1 = new System.Windows.Forms.Label();
            this.MasktextBox = new System.Windows.Forms.TextBox();
            this.Find_button = new System.Windows.Forms.Button();
            this.Copy_m_button = new System.Windows.Forms.Button();
            this.Getfiles_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть маску файлів (приклад: *.txt, *.html):";
            // 
            // MasktextBox
            // 
            this.MasktextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasktextBox.Location = new System.Drawing.Point(110, 144);
            this.MasktextBox.Name = "MasktextBox";
            this.MasktextBox.Size = new System.Drawing.Size(338, 26);
            this.MasktextBox.TabIndex = 1;
            // 
            // Find_button
            // 
            this.Find_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find_button.Location = new System.Drawing.Point(206, 232);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(139, 63);
            this.Find_button.TabIndex = 2;
            this.Find_button.Text = "Знайти файли";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // Copy_m_button
            // 
            this.Copy_m_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copy_m_button.Location = new System.Drawing.Point(206, 488);
            this.Copy_m_button.Name = "Copy_m_button";
            this.Copy_m_button.Size = new System.Drawing.Size(139, 63);
            this.Copy_m_button.TabIndex = 5;
            this.Copy_m_button.Text = "Скопіювати";
            this.Copy_m_button.UseVisualStyleBackColor = true;
            this.Copy_m_button.Click += new System.EventHandler(this.Copy_m_button_Click_1);
            // 
            // Getfiles_textBox
            // 
            this.Getfiles_textBox.Location = new System.Drawing.Point(110, 324);
            this.Getfiles_textBox.Multiline = true;
            this.Getfiles_textBox.Name = "Getfiles_textBox";
            this.Getfiles_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Getfiles_textBox.Size = new System.Drawing.Size(338, 133);
            this.Getfiles_textBox.TabIndex = 7;
            // 
            // Mask_ini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 574);
            this.Controls.Add(this.Getfiles_textBox);
            this.Controls.Add(this.Copy_m_button);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.MasktextBox);
            this.Controls.Add(this.label1);
            this.Name = "Mask_ini";
            this.Text = "Ініціалізіція маски";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MasktextBox;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.Button Copy_m_button;
        private System.Windows.Forms.TextBox Getfiles_textBox;
    }
}