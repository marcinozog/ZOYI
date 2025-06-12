namespace ZOYI
{
    partial class StandardDisplayPanel
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
            components = new System.ComponentModel.Container();
            lblLabel = new Label();
            lblValue = new Label();
            panelResize = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            contextMenuStdDisp = new ContextMenuStrip(components);
            toolStripMenuItemLabel = new ToolStripMenuItem();
            toolStripMenuItemValue = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            zamknijPaneToolStripMenuItem = new ToolStripMenuItem();
            lblFreq = new Label();
            lblMode = new Label();
            tableLayoutPanel.SuspendLayout();
            contextMenuStdDisp.SuspendLayout();
            SuspendLayout();
            // 
            // lblLabel
            // 
            lblLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLabel.ForeColor = SystemColors.HighlightText;
            lblLabel.Location = new Point(3, 0);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(383, 68);
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
            lblValue.Location = new Point(3, 68);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(383, 69);
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
            panelResize.Location = new Point(380, 160);
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
            tableLayoutPanel.Size = new Size(389, 137);
            tableLayoutPanel.TabIndex = 3;
            // 
            // contextMenuStdDisp
            // 
            contextMenuStdDisp.ImageScalingSize = new Size(24, 24);
            contextMenuStdDisp.Items.AddRange(new ToolStripItem[] { toolStripMenuItemLabel, toolStripMenuItemValue, toolStripSeparator1, zamknijPaneToolStripMenuItem });
            contextMenuStdDisp.Name = "contextMenuStdDisp";
            contextMenuStdDisp.Size = new Size(195, 106);
            // 
            // toolStripMenuItemLabel
            // 
            toolStripMenuItemLabel.Checked = true;
            toolStripMenuItemLabel.CheckOnClick = true;
            toolStripMenuItemLabel.CheckState = CheckState.Checked;
            toolStripMenuItemLabel.Name = "toolStripMenuItemLabel";
            toolStripMenuItemLabel.Size = new Size(194, 32);
            toolStripMenuItemLabel.Text = "Label";
            toolStripMenuItemLabel.CheckedChanged += toolStripMenuItem_CheckedChanged;
            // 
            // toolStripMenuItemValue
            // 
            toolStripMenuItemValue.Checked = true;
            toolStripMenuItemValue.CheckOnClick = true;
            toolStripMenuItemValue.CheckState = CheckState.Checked;
            toolStripMenuItemValue.Name = "toolStripMenuItemValue";
            toolStripMenuItemValue.Size = new Size(194, 32);
            toolStripMenuItemValue.Text = "Value";
            toolStripMenuItemValue.CheckedChanged += toolStripMenuItem_CheckedChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(191, 6);
            // 
            // zamknijPaneToolStripMenuItem
            // 
            zamknijPaneToolStripMenuItem.Name = "zamknijPaneToolStripMenuItem";
            zamknijPaneToolStripMenuItem.Size = new Size(194, 32);
            zamknijPaneToolStripMenuItem.Text = "Zamknij panel";
            zamknijPaneToolStripMenuItem.Click += zamknijPanelToolStripMenuItem_Click;
            // 
            // lblFreq
            // 
            lblFreq.AutoSize = true;
            lblFreq.Location = new Point(15, 160);
            lblFreq.Name = "lblFreq";
            lblFreq.Size = new Size(40, 25);
            lblFreq.TabIndex = 4;
            lblFreq.Text = "----";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Location = new Point(164, 160);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(40, 25);
            lblMode.TabIndex = 5;
            lblMode.Text = "----";
            // 
            // StandardDisplayPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(413, 190);
            ContextMenuStrip = contextMenuStdDisp;
            Controls.Add(lblMode);
            Controls.Add(lblFreq);
            Controls.Add(panelResize);
            Controls.Add(tableLayoutPanel);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StandardDisplayPanel";
            StartPosition = FormStartPosition.Manual;
            Text = "displayPanel";
            FormClosed += DisplayPanel_FormClosed;
            MouseDown += displayPanel_MouseDown;
            MouseMove += displayPanel_MouseMove;
            MouseUp += displayPanel_MouseUp;
            tableLayoutPanel.ResumeLayout(false);
            contextMenuStdDisp.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLabel;
        private Label lblValue;
        private Panel panelResize;
        private TableLayoutPanel tableLayoutPanel;
        private ContextMenuStrip contextMenuStdDisp;
        private ToolStripMenuItem toolStripMenuItemValue;
        private ToolStripMenuItem toolStripMenuItemLabel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem zamknijPaneToolStripMenuItem;
        private Label lblFreq;
        private Label lblMode;
    }
}