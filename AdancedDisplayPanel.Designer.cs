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
            lblLabel = new Label();
            lblValue = new Label();
            panelResize = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            arcProgressBar1 = new ArcProgressBar();
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
            lblLabel.Size = new Size(383, 54);
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
            lblValue.Location = new Point(3, 54);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(383, 55);
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
            panelResize.Enabled = false;
            panelResize.Location = new Point(392, 179);
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
            tableLayoutPanel.Location = new Point(12, 99);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(389, 109);
            tableLayoutPanel.TabIndex = 3;
            // 
            // arcProgressBar1
            // 
            arcProgressBar1.BackColor = Color.Transparent;
            arcProgressBar1.BarColor1 = Color.Orange;
            arcProgressBar1.BarColor2 = Color.Orange;
            arcProgressBar1.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            arcProgressBar1.BarWidth = 14F;
            arcProgressBar1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            arcProgressBar1.ForeColor = Color.DimGray;
            arcProgressBar1.LineColor = Color.DimGray;
            arcProgressBar1.LineWidth = 1;
            arcProgressBar1.Location = new Point(15, 3);
            arcProgressBar1.MajorThicksCount = 5L;
            arcProgressBar1.MaximumTick = 100F;
            arcProgressBar1.MinimumSize = new Size(100, 40);
            arcProgressBar1.Name = "arcProgressBar1";
            arcProgressBar1.ProgressShape = ArcProgressBar._ProgressShape.Flat;
            arcProgressBar1.Size = new Size(382, 100);
            arcProgressBar1.TabIndex = 4;
            arcProgressBar1.Text = "arcProgressBar1";
            arcProgressBar1.TextMode = ArcProgressBar._TextMode.None;
            arcProgressBar1.Value = 57F;
            arcProgressBar1.MouseDown += displayPanel_MouseDown;
            arcProgressBar1.MouseMove += displayPanel_MouseMove;
            arcProgressBar1.MouseUp += displayPanel_MouseUp;
            // 
            // AdancedDisplayPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(425, 209);
            Controls.Add(panelResize);
            Controls.Add(arcProgressBar1);
            Controls.Add(tableLayoutPanel);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdancedDisplayPanel";
            StartPosition = FormStartPosition.Manual;
            Text = "displayPanel";
            FormClosed += AdancedDisplayPanel_FormClosed;
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
        private ArcProgressBar arcProgressBar1;
    }
}