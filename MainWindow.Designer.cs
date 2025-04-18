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
            tbComOutput = new TextBox();
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
            cbCOMrawmode = new CheckBox();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            label5 = new Label();
            tbPanelOpacity = new TrackBar();
            btnPanelColorBg = new Button();
            btnPanelColorLabel = new Button();
            btnPanelColorValue = new Button();
            tabPage3 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            plAlarm = new Panel();
            cbAlarmLabel = new ComboBox();
            tbAlarmUnderValue = new TextBox();
            cbValueUnder = new CheckBox();
            tbAlarmOverValue = new TextBox();
            cbValueOver = new CheckBox();
            chbAlarm = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            tabLinks = new TabPage();
            btnLinksRefresh = new Button();
            btnLinksEdit = new Button();
            panelLinks = new Panel();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPanelOpacity).BeginInit();
            tabPage3.SuspendLayout();
            plAlarm.SuspendLayout();
            tabLinks.SuspendLayout();
            SuspendLayout();
            // 
            // btnListCOM
            // 
            btnListCOM.BackColor = SystemColors.Desktop;
            btnListCOM.Location = new Point(11, 68);
            btnListCOM.Name = "btnListCOM";
            btnListCOM.Size = new Size(194, 48);
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
            lbCOMs.Location = new Point(11, 122);
            lbCOMs.Name = "lbCOMs";
            lbCOMs.Size = new Size(194, 179);
            lbCOMs.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LightGreen;
            btnConnect.ForeColor = SystemColors.Desktop;
            btnConnect.Location = new Point(11, 354);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(194, 48);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Połącz";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // tbComOutput
            // 
            tbComOutput.BackColor = SystemColors.WindowText;
            tbComOutput.ForeColor = SystemColors.HighlightText;
            tbComOutput.Location = new Point(6, 7);
            tbComOutput.Multiline = true;
            tbComOutput.Name = "tbComOutput";
            tbComOutput.ScrollBars = ScrollBars.Vertical;
            tbComOutput.Size = new Size(354, 392);
            tbComOutput.TabIndex = 5;
            // 
            // chbShowPanel
            // 
            chbShowPanel.AutoSize = true;
            chbShowPanel.Location = new Point(14, 436);
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
            lblBaudRate.Location = new Point(11, 317);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(96, 25);
            lblBaudRate.TabIndex = 7;
            lblBaudRate.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(114, 313);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(90, 31);
            txtBaudRate.TabIndex = 8;
            txtBaudRate.Text = "115200";
            txtBaudRate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClearLog
            // 
            btnClearLog.BackColor = SystemColors.Desktop;
            btnClearLog.Location = new Point(366, 7);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(153, 48);
            btnClearLog.TabIndex = 9;
            btnClearLog.Text = "Wyczyść";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // btnSaveLog
            // 
            btnSaveLog.BackColor = SystemColors.Desktop;
            btnSaveLog.Location = new Point(366, 61);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(153, 48);
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
            button1.Size = new Size(51, 48);
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
            btnMinimize.Location = new Point(679, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(51, 48);
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
            tabControl1.Controls.Add(tabLinks);
            tabControl1.Location = new Point(229, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(560, 443);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Desktop;
            tabPage1.Controls.Add(cbCOMrawmode);
            tabPage1.Controls.Add(tbComOutput);
            tabPage1.Controls.Add(btnClearLog);
            tabPage1.Controls.Add(btnSaveLog);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(552, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Logi";
            // 
            // cbCOMrawmode
            // 
            cbCOMrawmode.AutoSize = true;
            cbCOMrawmode.Location = new Point(368, 115);
            cbCOMrawmode.Name = "cbCOMrawmode";
            cbCOMrawmode.Size = new Size(129, 29);
            cbCOMrawmode.TabIndex = 11;
            cbCOMrawmode.Text = "RAW mode";
            cbCOMrawmode.UseVisualStyleBackColor = true;
            cbCOMrawmode.CheckedChanged += cbCOMrawmode_CheckedChanged;
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
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbPanelOpacity);
            groupBox1.Controls.Add(btnPanelColorBg);
            groupBox1.Controls.Add(btnPanelColorLabel);
            groupBox1.Controls.Add(btnPanelColorValue);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(6, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 197);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Panel miernika";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 98);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 13;
            label5.Text = "Przeźroczystość";
            // 
            // tbPanelOpacity
            // 
            tbPanelOpacity.Location = new Point(161, 98);
            tbPanelOpacity.Maximum = 100;
            tbPanelOpacity.Minimum = 20;
            tbPanelOpacity.Name = "tbPanelOpacity";
            tbPanelOpacity.Size = new Size(289, 69);
            tbPanelOpacity.TabIndex = 12;
            tbPanelOpacity.Value = 100;
            tbPanelOpacity.Scroll += tbPanelOpacity_Scroll;
            // 
            // btnPanelColorBg
            // 
            btnPanelColorBg.BackColor = SystemColors.Desktop;
            btnPanelColorBg.Location = new Point(13, 32);
            btnPanelColorBg.Name = "btnPanelColorBg";
            btnPanelColorBg.Size = new Size(141, 48);
            btnPanelColorBg.TabIndex = 8;
            btnPanelColorBg.Text = "Kolor tła";
            btnPanelColorBg.UseVisualStyleBackColor = false;
            btnPanelColorBg.Click += btnColorBg_Click;
            // 
            // btnPanelColorLabel
            // 
            btnPanelColorLabel.BackColor = SystemColors.Desktop;
            btnPanelColorLabel.Location = new Point(161, 32);
            btnPanelColorLabel.Name = "btnPanelColorLabel";
            btnPanelColorLabel.Size = new Size(141, 48);
            btnPanelColorLabel.TabIndex = 9;
            btnPanelColorLabel.Text = "Kolor etykiety";
            btnPanelColorLabel.UseVisualStyleBackColor = false;
            btnPanelColorLabel.Click += btnColorLabel_Click;
            // 
            // btnPanelColorValue
            // 
            btnPanelColorValue.BackColor = SystemColors.Desktop;
            btnPanelColorValue.Location = new Point(309, 32);
            btnPanelColorValue.Name = "btnPanelColorValue";
            btnPanelColorValue.Size = new Size(141, 48);
            btnPanelColorValue.TabIndex = 11;
            btnPanelColorValue.Text = "Kolor wartości";
            btnPanelColorValue.UseVisualStyleBackColor = false;
            btnPanelColorValue.Click += btnColorValue_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Desktop;
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(plAlarm);
            tabPage3.Controls.Add(chbAlarm);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(552, 405);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Alarm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(86, 146);
            label7.Name = "label7";
            label7.Size = new Size(25, 25);
            label7.TabIndex = 30;
            label7.Text = "<";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(86, 113);
            label6.Name = "label6";
            label6.Size = new Size(25, 25);
            label6.TabIndex = 29;
            label6.Text = ">";
            // 
            // plAlarm
            // 
            plAlarm.Controls.Add(cbAlarmLabel);
            plAlarm.Controls.Add(tbAlarmUnderValue);
            plAlarm.Controls.Add(cbValueUnder);
            plAlarm.Controls.Add(tbAlarmOverValue);
            plAlarm.Controls.Add(cbValueOver);
            plAlarm.Location = new Point(114, 56);
            plAlarm.Name = "plAlarm";
            plAlarm.Size = new Size(200, 134);
            plAlarm.TabIndex = 26;
            // 
            // cbAlarmLabel
            // 
            cbAlarmLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlarmLabel.FormattingEnabled = true;
            cbAlarmLabel.Items.AddRange(new object[] { "Voltage", "Ohm", "Resistance", "Capacity", "Diode" });
            cbAlarmLabel.Location = new Point(36, 11);
            cbAlarmLabel.Name = "cbAlarmLabel";
            cbAlarmLabel.Size = new Size(150, 33);
            cbAlarmLabel.TabIndex = 22;
            // 
            // tbAlarmUnderValue
            // 
            tbAlarmUnderValue.Location = new Point(36, 89);
            tbAlarmUnderValue.Name = "tbAlarmUnderValue";
            tbAlarmUnderValue.Size = new Size(150, 31);
            tbAlarmUnderValue.TabIndex = 25;
            tbAlarmUnderValue.Text = "4";
            // 
            // cbValueUnder
            // 
            cbValueUnder.AutoSize = true;
            cbValueUnder.Location = new Point(3, 95);
            cbValueUnder.Name = "cbValueUnder";
            cbValueUnder.Size = new Size(22, 21);
            cbValueUnder.TabIndex = 28;
            cbValueUnder.UseVisualStyleBackColor = true;
            // 
            // tbAlarmOverValue
            // 
            tbAlarmOverValue.Location = new Point(36, 54);
            tbAlarmOverValue.Name = "tbAlarmOverValue";
            tbAlarmOverValue.Size = new Size(150, 31);
            tbAlarmOverValue.TabIndex = 19;
            tbAlarmOverValue.Text = "5";
            // 
            // cbValueOver
            // 
            cbValueOver.AutoSize = true;
            cbValueOver.Checked = true;
            cbValueOver.CheckState = CheckState.Checked;
            cbValueOver.Location = new Point(3, 60);
            cbValueOver.Name = "cbValueOver";
            cbValueOver.Size = new Size(22, 21);
            cbValueOver.TabIndex = 27;
            cbValueOver.UseVisualStyleBackColor = true;
            // 
            // chbAlarm
            // 
            chbAlarm.AutoSize = true;
            chbAlarm.Location = new Point(10, 7);
            chbAlarm.Name = "chbAlarm";
            chbAlarm.Size = new Size(85, 29);
            chbAlarm.TabIndex = 18;
            chbAlarm.Text = "Alarm";
            chbAlarm.UseVisualStyleBackColor = true;
            chbAlarm.CheckedChanged += chbAlarm_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(0, 125);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 21;
            label2.Text = "Wartość:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(0, 70);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 20;
            label3.Text = "Etykieta:";
            // 
            // tabLinks
            // 
            tabLinks.BackColor = Color.Black;
            tabLinks.Controls.Add(btnLinksRefresh);
            tabLinks.Controls.Add(btnLinksEdit);
            tabLinks.Controls.Add(panelLinks);
            tabLinks.Location = new Point(4, 34);
            tabLinks.Name = "tabLinks";
            tabLinks.Padding = new Padding(3);
            tabLinks.Size = new Size(552, 405);
            tabLinks.TabIndex = 3;
            tabLinks.Text = "Linki";
            // 
            // btnLinksRefresh
            // 
            btnLinksRefresh.BackColor = Color.Black;
            btnLinksRefresh.Location = new Point(406, 60);
            btnLinksRefresh.Name = "btnLinksRefresh";
            btnLinksRefresh.Size = new Size(140, 48);
            btnLinksRefresh.TabIndex = 2;
            btnLinksRefresh.Text = "Odśwież";
            btnLinksRefresh.UseVisualStyleBackColor = false;
            btnLinksRefresh.Click += btnLinksRefresh_Click;
            // 
            // btnLinksEdit
            // 
            btnLinksEdit.BackColor = Color.Black;
            btnLinksEdit.Location = new Point(406, 6);
            btnLinksEdit.Name = "btnLinksEdit";
            btnLinksEdit.Size = new Size(140, 48);
            btnLinksEdit.TabIndex = 1;
            btnLinksEdit.Text = "Edytuj";
            btnLinksEdit.UseVisualStyleBackColor = false;
            btnLinksEdit.Click += btnLinksEdit_Click;
            // 
            // panelLinks
            // 
            panelLinks.AutoScroll = true;
            panelLinks.BorderStyle = BorderStyle.FixedSingle;
            panelLinks.Location = new Point(6, 6);
            panelLinks.Name = "panelLinks";
            panelLinks.Size = new Size(394, 393);
            panelLinks.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 485);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 15;
            label4.Text = "Wersja 0.15";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 525);
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
            StartPosition = FormStartPosition.Manual;
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
            plAlarm.ResumeLayout(false);
            plAlarm.PerformLayout();
            tabLinks.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListCOM;
        private ListBox lbCOMs;
        private Button btnConnect;
        private TextBox tbComOutput;
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
        private TextBox tbAlarmOverValue;
        private TrackBar tbPanelOpacity;
        private Label label5;
        private Label label6;
        private CheckBox cbValueUnder;
        private CheckBox cbValueOver;
        private Panel plAlarm;
        private TextBox tbAlarmUnderValue;
        private Label label7;
        private TabPage tabLinks;
        private Button btnLinksRefresh;
        private Button btnLinksEdit;
        private Panel panelLinks;
        private CheckBox cbCOMrawmode;
    }
}
