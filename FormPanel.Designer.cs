﻿namespace ZOYI
{
    partial class FormPanel
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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(60, 13);
            label1.Name = "label1";
            label1.Size = new Size(260, 80);
            label1.TabIndex = 0;
            label1.Text = "Capacity";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += FormPanel_MouseDown;
            label1.MouseMove += FormPanel_MouseMove;
            label1.MouseUp += FormPanel_MouseUp;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(60, 100);
            label2.Name = "label2";
            label2.Size = new Size(260, 80);
            label2.TabIndex = 1;
            label2.Text = "100uF";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.MouseDown += FormPanel_MouseDown;
            label2.MouseMove += FormPanel_MouseMove;
            label2.MouseUp += FormPanel_MouseUp;
            // 
            // FormPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(385, 192);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPanel";
            Text = "FormPanel";
            MouseDown += FormPanel_MouseDown;
            MouseMove += FormPanel_MouseMove;
            MouseUp += FormPanel_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}