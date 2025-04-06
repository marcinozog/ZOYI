namespace ZOYI
{
    partial class MainWindow
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
            btnListCOM = new Button();
            lbCOMs = new ListBox();
            btnConnect = new Button();
            txtOutput = new TextBox();
            chbShowPanel = new CheckBox();
            lblBaudRate = new Label();
            txtBaudRate = new TextBox();
            btnClearLog = new Button();
            btnSaveLog = new Button();
            button1 = new Button();
            label1 = new Label();
            btnMinimize = new Button();
            SuspendLayout();
            // 
            // btnListCOM
            // 
            btnListCOM.BackColor = SystemColors.Desktop;
            btnListCOM.Location = new Point(12, 55);
            btnListCOM.Name = "btnListCOM";
            btnListCOM.Size = new Size(194, 34);
            btnListCOM.TabIndex = 1;
            btnListCOM.Text = "Odśwież listę portów";
            btnListCOM.UseVisualStyleBackColor = false;
            btnListCOM.Click += btnListCOM_Click;
            // 
            // lbCOMs
            // 
            lbCOMs.BackColor = SystemColors.Desktop;
            lbCOMs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCOMs.ForeColor = SystemColors.HighlightText;
            lbCOMs.FormattingEnabled = true;
            lbCOMs.ItemHeight = 25;
            lbCOMs.Location = new Point(12, 95);
            lbCOMs.Name = "lbCOMs";
            lbCOMs.Size = new Size(194, 154);
            lbCOMs.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LightGreen;
            btnConnect.ForeColor = SystemColors.Desktop;
            btnConnect.Location = new Point(12, 311);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(194, 34);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Połącz";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.WindowText;
            txtOutput.ForeColor = SystemColors.HighlightText;
            txtOutput.Location = new Point(517, 61);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(271, 380);
            txtOutput.TabIndex = 5;
            // 
            // chbShowPanel
            // 
            chbShowPanel.AutoSize = true;
            chbShowPanel.Location = new Point(12, 452);
            chbShowPanel.Name = "chbShowPanel";
            chbShowPanel.Size = new Size(79, 29);
            chbShowPanel.TabIndex = 6;
            chbShowPanel.Text = "Panel";
            chbShowPanel.UseVisualStyleBackColor = true;
            chbShowPanel.CheckedChanged += chbShowPanel_CheckedChanged;
            // 
            // lblBaudRate
            // 
            lblBaudRate.AutoSize = true;
            lblBaudRate.Location = new Point(14, 271);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(96, 25);
            lblBaudRate.TabIndex = 7;
            lblBaudRate.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(117, 268);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(89, 31);
            txtBaudRate.TabIndex = 8;
            txtBaudRate.Text = "115200";
            txtBaudRate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClearLog
            // 
            btnClearLog.BackColor = SystemColors.Desktop;
            btnClearLog.Location = new Point(517, 447);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(112, 34);
            btnClearLog.TabIndex = 9;
            btnClearLog.Text = "Wyczyść";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // btnSaveLog
            // 
            btnSaveLog.BackColor = SystemColors.Desktop;
            btnSaveLog.Location = new Point(635, 447);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(153, 34);
            btnSaveLog.TabIndex = 10;
            btnSaveLog.Text = "Zapisz do pliku";
            btnSaveLog.UseVisualStyleBackColor = false;
            btnSaveLog.Click += btnSaveLog_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(736, 12);
            button1.Name = "button1";
            button1.Size = new Size(52, 34);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 12;
            label1.Text = "ZOYI Terminal";
            label1.MouseDown += MainWindow_MouseDown;
            label1.MouseMove += MainWindow_MouseMove;
            label1.MouseUp += MainWindow_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Brown;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinimize.ForeColor = SystemColors.HighlightText;
            btnMinimize.Location = new Point(678, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(52, 34);
            btnMinimize.TabIndex = 13;
            btnMinimize.Text = "__";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 500);
            Controls.Add(btnMinimize);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnSaveLog);
            Controls.Add(btnClearLog);
            Controls.Add(txtBaudRate);
            Controls.Add(lblBaudRate);
            Controls.Add(chbShowPanel);
            Controls.Add(txtOutput);
            Controls.Add(btnConnect);
            Controls.Add(lbCOMs);
            Controls.Add(btnListCOM);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "ZOYI Terminal";
            FormClosed += Form1_FormClosed;
            MouseDown += MainWindow_MouseDown;
            MouseMove += MainWindow_MouseMove;
            MouseUp += MainWindow_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListCOM;
        private ListBox lbCOMs;
        private Button btnConnect;
        private TextBox txtOutput;
        private CheckBox chbShowPanel;
        private Label lblBaudRate;
        private TextBox txtBaudRate;
        private Button btnClearLog;
        private Button btnSaveLog;
        private Button button1;
        private Label label1;
        private Button btnMinimize;
    }
}
