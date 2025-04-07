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
            label5 = new Label();
            tbPanelOpacity = new TrackBar();
            btnPanelColorBg = new Button();
            btnPanelColorLabel = new Button();
            btnPanelColorValue = new Button();
            tabPage3 = new TabPage();
            rbValueUnder = new RadioButton();
            rbValueOver = new RadioButton();
            cbAlarmLabel = new ComboBox();
            chbAlarm = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            tbAlarmValue = new TextBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPanelOpacity).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnListCOM
            // 
            btnListCOM.BackColor = SystemColors.Desktop;
            btnListCOM.Location = new Point(8, 39);
            btnListCOM.Margin = new Padding(2);
            btnListCOM.Name = "btnListCOM";
            btnListCOM.Size = new Size(136, 23);
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
            lbCOMs.ItemHeight = 15;
            lbCOMs.Location = new Point(8, 66);
            lbCOMs.Margin = new Padding(2);
            lbCOMs.Name = "lbCOMs";
            lbCOMs.Size = new Size(137, 94);
            lbCOMs.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LightGreen;
            btnConnect.ForeColor = SystemColors.Desktop;
            btnConnect.Location = new Point(8, 193);
            btnConnect.Margin = new Padding(2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(136, 24);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Połącz";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.WindowText;
            txtOutput.ForeColor = SystemColors.HighlightText;
            txtOutput.Location = new Point(4, 4);
            txtOutput.Margin = new Padding(2);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(249, 237);
            txtOutput.TabIndex = 5;
            // 
            // chbShowPanel
            // 
            chbShowPanel.AutoSize = true;
            chbShowPanel.Location = new Point(10, 250);
            chbShowPanel.Margin = new Padding(2);
            chbShowPanel.Name = "chbShowPanel";
            chbShowPanel.Size = new Size(55, 19);
            chbShowPanel.TabIndex = 6;
            chbShowPanel.Text = "Panel";
            chbShowPanel.UseVisualStyleBackColor = true;
            chbShowPanel.CheckedChanged += chbShowPanel_CheckedChanged;
            // 
            // lblBaudRate
            // 
            lblBaudRate.AutoSize = true;
            lblBaudRate.Location = new Point(8, 169);
            lblBaudRate.Margin = new Padding(2, 0, 2, 0);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(63, 15);
            lblBaudRate.TabIndex = 7;
            lblBaudRate.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(80, 166);
            txtBaudRate.Margin = new Padding(2);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(64, 23);
            txtBaudRate.TabIndex = 8;
            txtBaudRate.Text = "115200";
            txtBaudRate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClearLog
            // 
            btnClearLog.BackColor = SystemColors.Desktop;
            btnClearLog.Location = new Point(256, 4);
            btnClearLog.Margin = new Padding(2);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(107, 25);
            btnClearLog.TabIndex = 9;
            btnClearLog.Text = "Wyczyść";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // btnSaveLog
            // 
            btnSaveLog.BackColor = SystemColors.Desktop;
            btnSaveLog.Location = new Point(256, 33);
            btnSaveLog.Margin = new Padding(2);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(107, 23);
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
            button1.Location = new Point(515, 7);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(36, 29);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(137, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 20);
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
            btnMinimize.Location = new Point(475, 7);
            btnMinimize.Margin = new Padding(2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(36, 29);
            btnMinimize.TabIndex = 13;
            btnMinimize.Text = "__";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(160, 40);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(392, 266);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Desktop;
            tabPage1.Controls.Add(txtOutput);
            tabPage1.Controls.Add(btnClearLog);
            tabPage1.Controls.Add(btnSaveLog);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(384, 238);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Logi";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Desktop;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(384, 238);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ustawienia";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Desktop;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbPanelOpacity);
            groupBox1.Controls.Add(btnPanelColorBg);
            groupBox1.Controls.Add(btnPanelColorLabel);
            groupBox1.Controls.Add(btnPanelColorValue);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(4, 6);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(322, 118);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Panel miernika";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 59);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 13;
            label5.Text = "Przeźroczystość";
            // 
            // tbPanelOpacity
            // 
            tbPanelOpacity.Location = new Point(113, 59);
            tbPanelOpacity.Margin = new Padding(2);
            tbPanelOpacity.Maximum = 100;
            tbPanelOpacity.Minimum = 20;
            tbPanelOpacity.Name = "tbPanelOpacity";
            tbPanelOpacity.Size = new Size(202, 45);
            tbPanelOpacity.TabIndex = 12;
            tbPanelOpacity.Value = 100;
            tbPanelOpacity.Scroll += tbPanelOpacity_Scroll;
            // 
            // btnPanelColorBg
            // 
            btnPanelColorBg.BackColor = SystemColors.Desktop;
            btnPanelColorBg.Location = new Point(9, 19);
            btnPanelColorBg.Margin = new Padding(2);
            btnPanelColorBg.Name = "btnPanelColorBg";
            btnPanelColorBg.Size = new Size(99, 29);
            btnPanelColorBg.TabIndex = 8;
            btnPanelColorBg.Text = "Kolor tła";
            btnPanelColorBg.UseVisualStyleBackColor = false;
            btnPanelColorBg.Click += btnColorBg_Click;
            // 
            // btnPanelColorLabel
            // 
            btnPanelColorLabel.BackColor = SystemColors.Desktop;
            btnPanelColorLabel.Location = new Point(113, 19);
            btnPanelColorLabel.Margin = new Padding(2);
            btnPanelColorLabel.Name = "btnPanelColorLabel";
            btnPanelColorLabel.Size = new Size(99, 29);
            btnPanelColorLabel.TabIndex = 9;
            btnPanelColorLabel.Text = "Kolor etykiety";
            btnPanelColorLabel.UseVisualStyleBackColor = false;
            btnPanelColorLabel.Click += btnColorLabel_Click;
            // 
            // btnPanelColorValue
            // 
            btnPanelColorValue.BackColor = SystemColors.Desktop;
            btnPanelColorValue.Location = new Point(216, 19);
            btnPanelColorValue.Margin = new Padding(2);
            btnPanelColorValue.Name = "btnPanelColorValue";
            btnPanelColorValue.Size = new Size(99, 29);
            btnPanelColorValue.TabIndex = 11;
            btnPanelColorValue.Text = "Kolor wartości";
            btnPanelColorValue.UseVisualStyleBackColor = false;
            btnPanelColorValue.Click += btnColorValue_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Desktop;
            tabPage3.Controls.Add(rbValueUnder);
            tabPage3.Controls.Add(rbValueOver);
            tabPage3.Controls.Add(cbAlarmLabel);
            tabPage3.Controls.Add(chbAlarm);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(tbAlarmValue);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(384, 238);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Alarm";
            // 
            // rbValueUnder
            // 
            rbValueUnder.AutoSize = true;
            rbValueUnder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbValueUnder.Location = new Point(72, 77);
            rbValueUnder.Margin = new Padding(2);
            rbValueUnder.Name = "rbValueUnder";
            rbValueUnder.Size = new Size(33, 19);
            rbValueUnder.TabIndex = 24;
            rbValueUnder.Text = "<";
            rbValueUnder.UseVisualStyleBackColor = true;
            // 
            // rbValueOver
            // 
            rbValueOver.AutoSize = true;
            rbValueOver.Checked = true;
            rbValueOver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbValueOver.Location = new Point(72, 59);
            rbValueOver.Margin = new Padding(2);
            rbValueOver.Name = "rbValueOver";
            rbValueOver.Size = new Size(33, 19);
            rbValueOver.TabIndex = 23;
            rbValueOver.TabStop = true;
            rbValueOver.Text = ">";
            rbValueOver.UseVisualStyleBackColor = true;
            // 
            // cbAlarmLabel
            // 
            cbAlarmLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlarmLabel.FormattingEnabled = true;
            cbAlarmLabel.Items.AddRange(new object[] { "Voltage", "Ohm", "Resistance", "Capacity", "Diode" });
            cbAlarmLabel.Location = new Point(111, 29);
            cbAlarmLabel.Margin = new Padding(2);
            cbAlarmLabel.Name = "cbAlarmLabel";
            cbAlarmLabel.Size = new Size(106, 23);
            cbAlarmLabel.TabIndex = 22;
            // 
            // chbAlarm
            // 
            chbAlarm.AutoSize = true;
            chbAlarm.Location = new Point(7, 4);
            chbAlarm.Margin = new Padding(2);
            chbAlarm.Name = "chbAlarm";
            chbAlarm.Size = new Size(58, 19);
            chbAlarm.TabIndex = 18;
            chbAlarm.Text = "Alarm";
            chbAlarm.UseVisualStyleBackColor = true;
            chbAlarm.CheckedChanged += chbAlarm_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(4, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 21;
            label2.Text = "Wartość:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(4, 31);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 20;
            label3.Text = "Etykieta:";
            // 
            // tbAlarmValue
            // 
            tbAlarmValue.Location = new Point(111, 67);
            tbAlarmValue.Margin = new Padding(2);
            tbAlarmValue.Name = "tbAlarmValue";
            tbAlarmValue.Size = new Size(106, 23);
            tbAlarmValue.TabIndex = 19;
            tbAlarmValue.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 291);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 15;
            label4.Text = "Wersja 0.12";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(560, 315);
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
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "ZOYI Terminal";
            FormClosed += MainWindow_FormClosed;
            MouseDown += MainWindow_MouseDown;
            MouseMove += MainWindow_MouseMove;
            MouseUp += MainWindow_MouseUp;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbPanelOpacity).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private Button btnPanelColorValue;
        private Button btnPanelColorLabel;
        private Button btnPanelColorBg;
        private GroupBox groupBox1;
        private Label label4;
        private TabPage tabPage3;
        private ComboBox cbAlarmLabel;
        private CheckBox chbAlarm;
        private Label label2;
        private Label label3;
        private TextBox tbAlarmValue;
        private RadioButton rbValueUnder;
        private RadioButton rbValueOver;
        private TrackBar tbPanelOpacity;
        private Label label5;
    }
}
