namespace ZOYI
{
    partial class AdancedDisplayPanel
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
            arcProgressBar1 = new ArcProgressBar();
            contextMenuAdvDisp = new ContextMenuStrip(components);
            toolStripMenuItemArcBar = new ToolStripMenuItem();
            toolStripMenuItemValue = new ToolStripMenuItem();
            toolStripMenuItemLabel = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            zamknijPanelToolStripMenuItem = new ToolStripMenuItem();
            contextMenuAdvDisp.SuspendLayout();
            SuspendLayout();
            // 
            // lblLabel
            // 
            lblLabel.Anchor = AnchorStyles.None;
            lblLabel.BackColor = Color.Transparent;
            lblLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLabel.ForeColor = SystemColors.HighlightText;
            lblLabel.Location = new Point(72, 77);
            lblLabel.Margin = new Padding(2, 0, 2, 0);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(148, 30);
            lblLabel.TabIndex = 0;
            lblLabel.Text = "ZOYI 703s";
            lblLabel.TextAlign = ContentAlignment.MiddleCenter;
            lblLabel.MouseDown += displayPanel_MouseDown;
            lblLabel.MouseMove += displayPanel_MouseMove;
            lblLabel.MouseUp += displayPanel_MouseUp;
            // 
            // lblValue
            // 
            lblValue.Anchor = AnchorStyles.None;
            lblValue.BackColor = Color.Transparent;
            lblValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValue.ForeColor = SystemColors.HighlightText;
            lblValue.Location = new Point(55, 42);
            lblValue.Margin = new Padding(2, 0, 2, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(185, 35);
            lblValue.TabIndex = 1;
            lblValue.Text = "-0.0004 DC";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
            lblValue.MouseDown += displayPanel_MouseDown;
            lblValue.MouseMove += displayPanel_MouseMove;
            lblValue.MouseUp += displayPanel_MouseUp;
            // 
            // panelResize
            // 
            panelResize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelResize.Cursor = Cursors.SizeNWSE;
            panelResize.Enabled = false;
            panelResize.Location = new Point(274, 104);
            panelResize.Margin = new Padding(2, 2, 2, 2);
            panelResize.Name = "panelResize";
            panelResize.Size = new Size(23, 19);
            panelResize.TabIndex = 2;
            panelResize.MouseDown += panelResize_MouseDown;
            panelResize.MouseMove += panelResize_MouseMove;
            panelResize.MouseUp += panelResize_MouseUp;
            // 
            // arcProgressBar1
            // 
            arcProgressBar1.BackColor = Color.Transparent;
            arcProgressBar1.BarColor1 = Color.Orange;
            arcProgressBar1.BarColor2 = Color.Orange;
            arcProgressBar1.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            arcProgressBar1.BarWidth = 14F;
            arcProgressBar1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            arcProgressBar1.ForeColor = Color.DimGray;
            arcProgressBar1.LineColor = Color.DimGray;
            arcProgressBar1.LineWidth = 1;
            arcProgressBar1.Location = new Point(2, -1);
            arcProgressBar1.MajorThicksCount = 5L;
            arcProgressBar1.Margin = new Padding(2, 2, 2, 2);
            arcProgressBar1.MaximumTick = 100F;
            arcProgressBar1.MinimumSize = new Size(70, 24);
            arcProgressBar1.Name = "arcProgressBar1";
            arcProgressBar1.ProgressShape = ArcProgressBar._ProgressShape.Flat;
            arcProgressBar1.Size = new Size(295, 91);
            arcProgressBar1.TabIndex = 4;
            arcProgressBar1.Text = "arcProgressBar1";
            arcProgressBar1.TextMode = ArcProgressBar._TextMode.None;
            arcProgressBar1.Value = 57F;
            arcProgressBar1.MouseDown += displayPanel_MouseDown;
            arcProgressBar1.MouseMove += displayPanel_MouseMove;
            arcProgressBar1.MouseUp += displayPanel_MouseUp;
            // 
            // contextMenuAdvDisp
            // 
            contextMenuAdvDisp.ImageScalingSize = new Size(24, 24);
            contextMenuAdvDisp.Items.AddRange(new ToolStripItem[] { toolStripMenuItemArcBar, toolStripMenuItemValue, toolStripMenuItemLabel, toolStripSeparator1, zamknijPanelToolStripMenuItem });
            contextMenuAdvDisp.Name = "contextMenuAdvDisp";
            contextMenuAdvDisp.ShowCheckMargin = true;
            contextMenuAdvDisp.Size = new Size(172, 98);
            // 
            // toolStripMenuItemArcBar
            // 
            toolStripMenuItemArcBar.Checked = true;
            toolStripMenuItemArcBar.CheckOnClick = true;
            toolStripMenuItemArcBar.CheckState = CheckState.Checked;
            toolStripMenuItemArcBar.Name = "toolStripMenuItemArcBar";
            toolStripMenuItemArcBar.Size = new Size(171, 22);
            toolStripMenuItemArcBar.Text = "ArcBar";
            toolStripMenuItemArcBar.CheckedChanged += toolStripMenuItem_CheckedChanged;
            // 
            // toolStripMenuItemValue
            // 
            toolStripMenuItemValue.Checked = true;
            toolStripMenuItemValue.CheckOnClick = true;
            toolStripMenuItemValue.CheckState = CheckState.Checked;
            toolStripMenuItemValue.Name = "toolStripMenuItemValue";
            toolStripMenuItemValue.Size = new Size(171, 22);
            toolStripMenuItemValue.Text = "Value";
            toolStripMenuItemValue.CheckedChanged += toolStripMenuItem_CheckedChanged;
            // 
            // toolStripMenuItemLabel
            // 
            toolStripMenuItemLabel.Checked = true;
            toolStripMenuItemLabel.CheckOnClick = true;
            toolStripMenuItemLabel.CheckState = CheckState.Checked;
            toolStripMenuItemLabel.Name = "toolStripMenuItemLabel";
            toolStripMenuItemLabel.Size = new Size(171, 22);
            toolStripMenuItemLabel.Text = "Label";
            toolStripMenuItemLabel.CheckedChanged += toolStripMenuItem_CheckedChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(168, 6);
            // 
            // zamknijPanelToolStripMenuItem
            // 
            zamknijPanelToolStripMenuItem.Name = "zamknijPanelToolStripMenuItem";
            zamknijPanelToolStripMenuItem.Size = new Size(171, 22);
            zamknijPanelToolStripMenuItem.Text = "Zamknij panel";
            zamknijPanelToolStripMenuItem.Click += zamknijPanelToolStripMenuItem_Click;
            // 
            // AdancedDisplayPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(298, 122);
            ContextMenuStrip = contextMenuAdvDisp;
            Controls.Add(lblLabel);
            Controls.Add(lblValue);
            Controls.Add(panelResize);
            Controls.Add(arcProgressBar1);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdancedDisplayPanel";
            StartPosition = FormStartPosition.Manual;
            Text = "displayPanel";
            FormClosed += AdancedDisplayPanel_FormClosed;
            MouseDown += displayPanel_MouseDown;
            MouseMove += displayPanel_MouseMove;
            MouseUp += displayPanel_MouseUp;
            contextMenuAdvDisp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblLabel;
        private Label lblValue;
        private Panel panelResize;
        private ArcProgressBar arcProgressBar1;
        private ContextMenuStrip contextMenuAdvDisp;
        private ToolStripMenuItem toolStripMenuItemArcBar;
        private ToolStripMenuItem toolStripMenuItemLabel;
        private ToolStripMenuItem toolStripMenuItemValue;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem zamknijPanelToolStripMenuItem;
    }
}