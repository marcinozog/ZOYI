namespace ZOYI
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
            btnListCOM = new Button();
            lbCOMs = new ListBox();
            btnConnect = new Button();
            txtOutput = new TextBox();
            chbShowPanel = new CheckBox();
            lblBaudRate = new Label();
            txtBaudRate = new TextBox();
            btnClearLog = new Button();
            btnSaveLog = new Button();
            SuspendLayout();
            // 
            // btnListCOM
            // 
            btnListCOM.Location = new Point(12, 12);
            btnListCOM.Name = "btnListCOM";
            btnListCOM.Size = new Size(194, 34);
            btnListCOM.TabIndex = 1;
            btnListCOM.Text = "Odśwież listę portów";
            btnListCOM.UseVisualStyleBackColor = true;
            btnListCOM.Click += btnListCOM_Click;
            // 
            // lbCOMs
            // 
            lbCOMs.FormattingEnabled = true;
            lbCOMs.ItemHeight = 25;
            lbCOMs.Location = new Point(12, 52);
            lbCOMs.Name = "lbCOMs";
            lbCOMs.Size = new Size(194, 154);
            lbCOMs.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LightGreen;
            btnConnect.Location = new Point(12, 268);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(194, 34);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Połącz";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(517, 18);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(271, 380);
            txtOutput.TabIndex = 5;
            // 
            // chbShowPanel
            // 
            chbShowPanel.AutoSize = true;
            chbShowPanel.Location = new Point(12, 409);
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
            lblBaudRate.Location = new Point(14, 228);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(96, 25);
            lblBaudRate.TabIndex = 7;
            lblBaudRate.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(117, 225);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(89, 31);
            txtBaudRate.TabIndex = 8;
            txtBaudRate.Text = "115200";
            txtBaudRate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClearLog
            // 
            btnClearLog.Location = new Point(517, 404);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(112, 34);
            btnClearLog.TabIndex = 9;
            btnClearLog.Text = "Wyczyść";
            btnClearLog.UseVisualStyleBackColor = true;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // btnSaveLog
            // 
            btnSaveLog.Location = new Point(635, 404);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(153, 34);
            btnSaveLog.TabIndex = 10;
            btnSaveLog.Text = "Zapisz do pliku";
            btnSaveLog.UseVisualStyleBackColor = true;
            btnSaveLog.Click += btnSaveLog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveLog);
            Controls.Add(btnClearLog);
            Controls.Add(txtBaudRate);
            Controls.Add(lblBaudRate);
            Controls.Add(chbShowPanel);
            Controls.Add(txtOutput);
            Controls.Add(btnConnect);
            Controls.Add(lbCOMs);
            Controls.Add(btnListCOM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "ZOYI Terminal";
            FormClosed += Form1_FormClosed;
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
    }
}
