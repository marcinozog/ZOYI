﻿namespace ZOYI
{
    partial class DisplayPanel
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
            lblLabel = new Label();
            lblValue = new Label();
            panelResize = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblLabel
            // 
            lblLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLabel.ForeColor = SystemColors.HighlightText;
            lblLabel.Location = new Point(3, 0);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(383, 102);
            lblLabel.TabIndex = 0;
            lblLabel.Text = "ZOYI 703s";
            lblLabel.TextAlign = ContentAlignment.MiddleCenter;
            lblLabel.MouseDown += displayPanel_MouseDown;
            lblLabel.MouseMove += displayPanel_MouseMove;
            lblLabel.MouseUp += displayPanel_MouseUp;
            // 
            // lblValue
            // 
            lblValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValue.ForeColor = SystemColors.HighlightText;
            lblValue.Location = new Point(3, 102);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(383, 102);
            lblValue.TabIndex = 1;
            lblValue.Text = "Podłącz miernik";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
            lblValue.MouseDown += displayPanel_MouseDown;
            lblValue.MouseMove += displayPanel_MouseMove;
            lblValue.MouseUp += displayPanel_MouseUp;
            // 
            // panelResize
            // 
            panelResize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelResize.Cursor = Cursors.SizeNWSE;
            panelResize.Location = new Point(380, 196);
            panelResize.Name = "panelResize";
            panelResize.Size = new Size(33, 31);
            panelResize.TabIndex = 2;
            panelResize.MouseDown += panelResize_MouseDown;
            panelResize.MouseMove += panelResize_MouseMove;
            panelResize.MouseUp += panelResize_MouseUp;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(lblValue, 0, 1);
            tableLayoutPanel.Controls.Add(lblLabel, 0, 0);
            tableLayoutPanel.Location = new Point(12, 10);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(389, 204);
            tableLayoutPanel.TabIndex = 3;
            // 
            // DisplayPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(413, 226);
            Controls.Add(panelResize);
            Controls.Add(tableLayoutPanel);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayPanel";
            StartPosition = FormStartPosition.Manual;
            Text = "displayPanel";
            FormClosed += DisplayPanel_FormClosed;
            MouseDown += displayPanel_MouseDown;
            MouseMove += displayPanel_MouseMove;
            MouseUp += displayPanel_MouseUp;
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblLabel;
        private Label lblValue;
        private Panel panelResize;
        private TableLayoutPanel tableLayoutPanel;
    }
}