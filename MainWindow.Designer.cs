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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            cbAlarmLabel = new ComboBox();
            chbAlarm = new CheckBox();
            label2 = new Label();
            btnColorBg = new Button();
            label3 = new Label();
            btnColorLabel = new Button();
            tbAlarmValue = new TextBox();
            btnColorValue = new Button();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            txtOutput.Location = new Point(6, 6);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(317, 393);
            txtOutput.TabIndex = 5;
            // 
            // chbShowPanel
            // 
            chbShowPanel.AutoSize = true;
            chbShowPanel.Location = new Point(14, 400);
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
            btnClearLog.Location = new Point(329, 6);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(153, 34);
            btnClearLog.TabIndex = 9;
            btnClearLog.Text = "Wyczyść";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // btnSaveLog
            // 
            btnSaveLog.BackColor = SystemColors.Desktop;
            btnSaveLog.Location = new Point(329, 46);
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
            label1.Location = new Point(196, 12);
            label1.Name = "label1";
            label1.Size = new Size(370, 30);
            label1.TabIndex = 12;
            label1.Text = "ZOYI 703s Osciloscope Multimeter";
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(228, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(560, 443);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Desktop;
            tabPage1.Controls.Add(txtOutput);
            tabPage1.Controls.Add(btnClearLog);
            tabPage1.Controls.Add(btnSaveLog);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(552, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Logi";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Desktop;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(552, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ustawienia";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Desktop;
            groupBox1.Controls.Add(cbAlarmLabel);
            groupBox1.Controls.Add(chbAlarm);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnColorBg);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnColorLabel);
            groupBox1.Controls.Add(tbAlarmValue);
            groupBox1.Controls.Add(btnColorValue);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 168);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Panel miernika";
            // 
            // cbAlarmLabel
            // 
            cbAlarmLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlarmLabel.FormattingEnabled = true;
            cbAlarmLabel.Items.AddRange(new object[] { "Ohm", "Voltage", "Resistance", "Diode" });
            cbAlarmLabel.Location = new Point(293, 74);
            cbAlarmLabel.Name = "cbAlarmLabel";
            cbAlarmLabel.Size = new Size(150, 33);
            cbAlarmLabel.TabIndex = 17;
            // 
            // chbAlarm
            // 
            chbAlarm.AutoSize = true;
            chbAlarm.Location = new Point(196, 32);
            chbAlarm.Name = "chbAlarm";
            chbAlarm.Size = new Size(85, 29);
            chbAlarm.TabIndex = 10;
            chbAlarm.Text = "Alarm";
            chbAlarm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(196, 117);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 15;
            label2.Text = "Wartość:";
            // 
            // btnColorBg
            // 
            btnColorBg.BackColor = SystemColors.Desktop;
            btnColorBg.Location = new Point(13, 32);
            btnColorBg.Name = "btnColorBg";
            btnColorBg.Size = new Size(142, 34);
            btnColorBg.TabIndex = 8;
            btnColorBg.Text = "Kolor tła";
            btnColorBg.UseVisualStyleBackColor = false;
            btnColorBg.Click += btnColorBg_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(196, 77);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 14;
            label3.Text = "Etykieta:";
            // 
            // btnColorLabel
            // 
            btnColorLabel.BackColor = SystemColors.Desktop;
            btnColorLabel.Location = new Point(13, 72);
            btnColorLabel.Name = "btnColorLabel";
            btnColorLabel.Size = new Size(141, 34);
            btnColorLabel.TabIndex = 9;
            btnColorLabel.Text = "Kolor etykiety";
            btnColorLabel.UseVisualStyleBackColor = false;
            btnColorLabel.Click += btnColorLabel_Click;
            // 
            // tbAlarmValue
            // 
            tbAlarmValue.Location = new Point(293, 112);
            tbAlarmValue.Name = "tbAlarmValue";
            tbAlarmValue.Size = new Size(150, 31);
            tbAlarmValue.TabIndex = 13;
            // 
            // btnColorValue
            // 
            btnColorValue.BackColor = SystemColors.Desktop;
            btnColorValue.Location = new Point(13, 112);
            btnColorValue.Name = "btnColorValue";
            btnColorValue.Size = new Size(142, 34);
            btnColorValue.TabIndex = 11;
            btnColorValue.Text = "Kolor wartości";
            btnColorValue.UseVisualStyleBackColor = false;
            btnColorValue.Click += btnColorValue_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 473);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 15;
            label4.Text = "Wersja 0.05";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 514);
            Controls.Add(label4);
            Controls.Add(tabControl1);
            Controls.Add(btnMinimize);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtBaudRate);
            Controls.Add(lblBaudRate);
            Controls.Add(chbShowPanel);
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label3;
        private TextBox tbAlarmValue;
        private Button btnColorValue;
        private CheckBox chbAlarm;
        private Button btnColorLabel;
        private Button btnColorBg;
        private GroupBox groupBox1;
        private ComboBox cbAlarmLabel;
        private Label label4;
    }
}
