﻿namespace WF_28._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lbtext = new ListBox();
            btclick = new Button();
            tbfile = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Список элементов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 325);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Введите путь к файлу: ";
            // 
            // lbtext
            // 
            lbtext.FormattingEnabled = true;
            lbtext.ItemHeight = 15;
            lbtext.Location = new Point(16, 57);
            lbtext.Name = "lbtext";
            lbtext.Size = new Size(501, 229);
            lbtext.TabIndex = 2;
            // 
            // btclick
            // 
            btclick.Location = new Point(460, 343);
            btclick.Name = "btclick";
            btclick.Size = new Size(90, 23);
            btclick.TabIndex = 3;
            btclick.Text = "записать";
            btclick.UseVisualStyleBackColor = true;
            btclick.Click += btclick_Click;
            // 
            // tbfile
            // 
            tbfile.Location = new Point(12, 343);
            tbfile.Name = "tbfile";
            tbfile.Size = new Size(442, 23);
            tbfile.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbfile);
            Controls.Add(btclick);
            Controls.Add(lbtext);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbtext;
        private Button btclick;
        private TextBox tbfile;
    }
}
