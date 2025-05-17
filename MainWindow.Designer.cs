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
            lbListCOMs = new ListBox();
            btnComConnect = new Button();
            tbComOutput = new TextBox();
            chbStandardPanel = new CheckBox();
            lblBaudRate = new Label();
            tbCOMBaudrate = new TextBox();
            btnClearLog = new Button();
            btnSaveLog = new Button();
            button1 = new Button();
            label1 = new Label();
            btnMinimize = new Button();
            tabControl1 = new TabControl();
            tabPageCOM = new TabPage();
            chbAdvancedPanel = new CheckBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            rbCOMparseRaw = new RadioButton();
            rbCOMparseLua = new RadioButton();
            rbCOMparseStd = new RadioButton();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            lblThicksCount = new Label();
            tbarThicksCount = new TrackBar();
            label11 = new Label();
            lblArcTicks = new Label();
            tbarArcTicks = new TrackBar();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            tbarPanelOpacity = new TrackBar();
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
            tabTools = new TabPage();
            btnToolsRefresh = new Button();
            btnToolsEdit = new Button();
            panelTools = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            lblComConnStatus = new Label();
            lblBTSPPconnStatus = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPageCOM.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbarThicksCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbarArcTicks).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbarPanelOpacity).BeginInit();
            tabPage3.SuspendLayout();
            plAlarm.SuspendLayout();
            tabTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnListCOM
            // 
            btnListCOM.BackColor = SystemColors.Desktop;
            btnListCOM.Location = new Point(6, 6);
            btnListCOM.Name = "btnListCOM";
            btnListCOM.Size = new Size(226, 60);
            btnListCOM.TabIndex = 1;
            btnListCOM.Text = "Odśwież listę portów";
            btnListCOM.UseVisualStyleBackColor = false;
            btnListCOM.Click += btnListCOM_Click;
            // 
            // lbListCOMs
            // 
            lbListCOMs.BackColor = SystemColors.Desktop;
            lbListCOMs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbListCOMs.ForeColor = SystemColors.HighlightText;
            lbListCOMs.FormattingEnabled = true;
            lbListCOMs.ItemHeight = 25;
            lbListCOMs.Location = new Point(6, 71);
            lbListCOMs.Name = "lbListCOMs";
            lbListCOMs.Size = new Size(226, 279);
            lbListCOMs.TabIndex = 2;
            // 
            // btnComConnect
            // 
            btnComConnect.BackColor = Color.LightGreen;
            btnComConnect.ForeColor = SystemColors.Desktop;
            btnComConnect.Location = new Point(6, 416);
            btnComConnect.Name = "btnComConnect";
            btnComConnect.Size = new Size(226, 60);
            btnComConnect.TabIndex = 3;
            btnComConnect.Text = "Połącz";
            btnComConnect.UseVisualStyleBackColor = false;
            btnComConnect.Click += btnComConnect_Click;
            // 
            // tbComOutput
            // 
            tbComOutput.BackColor = SystemColors.WindowText;
            tbComOutput.ForeColor = SystemColors.HighlightText;
            tbComOutput.Location = new Point(238, 6);
            tbComOutput.Multiline = true;
            tbComOutput.Name = "tbComOutput";
            tbComOutput.ScrollBars = ScrollBars.Vertical;
            tbComOutput.Size = new Size(371, 470);
            tbComOutput.TabIndex = 5;
            // 
            // chbStandardPanel
            // 
            chbStandardPanel.AutoSize = true;
            chbStandardPanel.Checked = true;
            chbStandardPanel.CheckState = CheckState.Checked;
            chbStandardPanel.Location = new Point(621, 396);
            chbStandardPanel.Name = "chbStandardPanel";
            chbStandardPanel.Size = new Size(187, 29);
            chbStandardPanel.TabIndex = 6;
            chbStandardPanel.Text = "Panel standardowy";
            chbStandardPanel.UseVisualStyleBackColor = true;
            chbStandardPanel.CheckedChanged += chbShowPanel_CheckedChanged;
            // 
            // lblBaudRate
            // 
            lblBaudRate.AutoSize = true;
            lblBaudRate.Location = new Point(3, 373);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(96, 25);
            lblBaudRate.TabIndex = 7;
            lblBaudRate.Text = "Baud Rate:";
            // 
            // tbCOMBaudrate
            // 
            tbCOMBaudrate.Location = new Point(142, 370);
            tbCOMBaudrate.Name = "tbCOMBaudrate";
            tbCOMBaudrate.Size = new Size(90, 31);
            tbCOMBaudrate.TabIndex = 8;
            tbCOMBaudrate.Text = "115200";
            tbCOMBaudrate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClearLog
            // 
            btnClearLog.BackColor = SystemColors.Desktop;
            btnClearLog.Location = new Point(615, 6);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(226, 60);
            btnClearLog.TabIndex = 9;
            btnClearLog.Text = "Wyczyść";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // btnSaveLog
            // 
            btnSaveLog.BackColor = SystemColors.Desktop;
            btnSaveLog.Location = new Point(615, 72);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(226, 60);
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
            button1.Location = new Point(818, 12);
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
            label1.Location = new Point(257, 20);
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
            btnMinimize.Location = new Point(761, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(51, 48);
            btnMinimize.TabIndex = 13;
            btnMinimize.Text = "__";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCOM);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabTools);
            tabControl1.Location = new Point(14, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(855, 534);
            tabControl1.TabIndex = 14;
            // 
            // tabPageCOM
            // 
            tabPageCOM.BackColor = SystemColors.Desktop;
            tabPageCOM.Controls.Add(chbAdvancedPanel);
            tabPageCOM.Controls.Add(groupBox2);
            tabPageCOM.Controls.Add(tbComOutput);
            tabPageCOM.Controls.Add(btnClearLog);
            tabPageCOM.Controls.Add(btnSaveLog);
            tabPageCOM.Controls.Add(chbStandardPanel);
            tabPageCOM.Controls.Add(btnListCOM);
            tabPageCOM.Controls.Add(lbListCOMs);
            tabPageCOM.Controls.Add(btnComConnect);
            tabPageCOM.Controls.Add(lblBaudRate);
            tabPageCOM.Controls.Add(tbCOMBaudrate);
            tabPageCOM.Location = new Point(4, 34);
            tabPageCOM.Name = "tabPageCOM";
            tabPageCOM.Padding = new Padding(3);
            tabPageCOM.Size = new Size(847, 496);
            tabPageCOM.TabIndex = 0;
            tabPageCOM.Text = "COM";
            // 
            // chbAdvancedPanel
            // 
            chbAdvancedPanel.AutoSize = true;
            chbAdvancedPanel.Checked = true;
            chbAdvancedPanel.CheckState = CheckState.Checked;
            chbAdvancedPanel.Location = new Point(621, 433);
            chbAdvancedPanel.Name = "chbAdvancedPanel";
            chbAdvancedPanel.Size = new Size(165, 29);
            chbAdvancedPanel.TabIndex = 13;
            chbAdvancedPanel.Text = "Panel z bajerami";
            chbAdvancedPanel.UseVisualStyleBackColor = true;
            chbAdvancedPanel.CheckedChanged += chbAdvancedPanel_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(rbCOMparseRaw);
            groupBox2.Controls.Add(rbCOMparseLua);
            groupBox2.Controls.Add(rbCOMparseStd);
            groupBox2.ForeColor = SystemColors.HighlightText;
            groupBox2.Location = new Point(615, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 174);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tryb wyświetlania";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Desktop;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(66, 77);
            button2.Name = "button2";
            button2.Size = new Size(98, 40);
            button2.TabIndex = 15;
            button2.Text = "Edytuj";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnCOMluaEdit_Click;
            // 
            // rbCOMparseRaw
            // 
            rbCOMparseRaw.AutoSize = true;
            rbCOMparseRaw.Location = new Point(6, 117);
            rbCOMparseRaw.Name = "rbCOMparseRaw";
            rbCOMparseRaw.Size = new Size(76, 29);
            rbCOMparseRaw.TabIndex = 14;
            rbCOMparseRaw.Text = "RAW";
            rbCOMparseRaw.UseVisualStyleBackColor = true;
            rbCOMparseRaw.CheckedChanged += rbComParse_CheckedChanged;
            // 
            // rbCOMparseLua
            // 
            rbCOMparseLua.AutoSize = true;
            rbCOMparseLua.Location = new Point(6, 82);
            rbCOMparseLua.Name = "rbCOMparseLua";
            rbCOMparseLua.Size = new Size(64, 29);
            rbCOMparseLua.TabIndex = 13;
            rbCOMparseLua.Text = "Lua";
            rbCOMparseLua.UseVisualStyleBackColor = true;
            rbCOMparseLua.CheckedChanged += rbComParse_CheckedChanged;
            // 
            // rbCOMparseStd
            // 
            rbCOMparseStd.AutoSize = true;
            rbCOMparseStd.Checked = true;
            rbCOMparseStd.Location = new Point(6, 47);
            rbCOMparseStd.Name = "rbCOMparseStd";
            rbCOMparseStd.Size = new Size(108, 29);
            rbCOMparseStd.TabIndex = 12;
            rbCOMparseStd.TabStop = true;
            rbCOMparseStd.Text = "Standard";
            rbCOMparseStd.UseVisualStyleBackColor = true;
            rbCOMparseStd.CheckedChanged += rbComParse_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Desktop;
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.ForeColor = SystemColors.HighlightText;
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(847, 496);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ustawienia";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblThicksCount);
            groupBox3.Controls.Add(tbarThicksCount);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lblArcTicks);
            groupBox3.Controls.Add(tbarArcTicks);
            groupBox3.Controls.Add(label10);
            groupBox3.ForeColor = SystemColors.HighlightText;
            groupBox3.Location = new Point(8, 259);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(833, 208);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Panel zaawansowany";
            // 
            // lblThicksCount
            // 
            lblThicksCount.AutoSize = true;
            lblThicksCount.Location = new Point(461, 123);
            lblThicksCount.Name = "lblThicksCount";
            lblThicksCount.Size = new Size(32, 25);
            lblThicksCount.TabIndex = 5;
            lblThicksCount.Text = "10";
            // 
            // tbarThicksCount
            // 
            tbarThicksCount.Location = new Point(159, 114);
            tbarThicksCount.Maximum = 50;
            tbarThicksCount.Minimum = 5;
            tbarThicksCount.Name = "tbarThicksCount";
            tbarThicksCount.Size = new Size(289, 69);
            tbarThicksCount.TabIndex = 4;
            tbarThicksCount.Value = 5;
            tbarThicksCount.Scroll += tbarThicksCount_Scroll;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 126);
            label11.Name = "label11";
            label11.Size = new Size(110, 25);
            label11.TabIndex = 3;
            label11.Text = "Thicks count";
            // 
            // lblArcTicks
            // 
            lblArcTicks.AutoSize = true;
            lblArcTicks.Location = new Point(454, 39);
            lblArcTicks.Name = "lblArcTicks";
            lblArcTicks.Size = new Size(32, 25);
            lblArcTicks.TabIndex = 2;
            lblArcTicks.Text = "25";
            // 
            // tbarArcTicks
            // 
            tbarArcTicks.Location = new Point(159, 39);
            tbarArcTicks.Maximum = 250;
            tbarArcTicks.Minimum = 10;
            tbarArcTicks.Name = "tbarArcTicks";
            tbarArcTicks.Size = new Size(289, 69);
            tbarArcTicks.TabIndex = 1;
            tbarArcTicks.TickFrequency = 5;
            tbarArcTicks.Value = 25;
            tbarArcTicks.Scroll += tbarArcTicks_Scroll;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 39);
            label10.Name = "label10";
            label10.Size = new Size(50, 25);
            label10.TabIndex = 0;
            label10.Text = "Ticks";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Desktop;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbarPanelOpacity);
            groupBox1.Controls.Add(btnPanelColorBg);
            groupBox1.Controls.Add(btnPanelColorLabel);
            groupBox1.Controls.Add(btnPanelColorValue);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(6, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 207);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Panel standardowy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 131);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 13;
            label5.Text = "Przeźroczystość";
            // 
            // tbarPanelOpacity
            // 
            tbarPanelOpacity.Location = new Point(161, 131);
            tbarPanelOpacity.Maximum = 100;
            tbarPanelOpacity.Minimum = 20;
            tbarPanelOpacity.Name = "tbarPanelOpacity";
            tbarPanelOpacity.Size = new Size(289, 69);
            tbarPanelOpacity.TabIndex = 12;
            tbarPanelOpacity.Value = 100;
            tbarPanelOpacity.Scroll += tbPanelOpacity_Scroll;
            // 
            // btnPanelColorBg
            // 
            btnPanelColorBg.BackColor = SystemColors.Desktop;
            btnPanelColorBg.Location = new Point(13, 32);
            btnPanelColorBg.Name = "btnPanelColorBg";
            btnPanelColorBg.Size = new Size(141, 60);
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
            btnPanelColorLabel.Size = new Size(141, 60);
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
            btnPanelColorValue.Size = new Size(141, 60);
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
            tabPage3.Size = new Size(847, 496);
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
            // tabTools
            // 
            tabTools.BackColor = Color.Black;
            tabTools.Controls.Add(btnToolsRefresh);
            tabTools.Controls.Add(btnToolsEdit);
            tabTools.Controls.Add(panelTools);
            tabTools.Location = new Point(4, 34);
            tabTools.Name = "tabTools";
            tabTools.Padding = new Padding(3);
            tabTools.Size = new Size(847, 496);
            tabTools.TabIndex = 3;
            tabTools.Text = "Tools";
            // 
            // btnToolsRefresh
            // 
            btnToolsRefresh.BackColor = Color.Black;
            btnToolsRefresh.Location = new Point(704, 72);
            btnToolsRefresh.Name = "btnToolsRefresh";
            btnToolsRefresh.Size = new Size(140, 60);
            btnToolsRefresh.TabIndex = 2;
            btnToolsRefresh.Text = "Odśwież";
            btnToolsRefresh.UseVisualStyleBackColor = false;
            btnToolsRefresh.Click += btnToolsRefresh_Click;
            // 
            // btnToolsEdit
            // 
            btnToolsEdit.BackColor = Color.Black;
            btnToolsEdit.Location = new Point(704, 6);
            btnToolsEdit.Name = "btnToolsEdit";
            btnToolsEdit.Size = new Size(140, 60);
            btnToolsEdit.TabIndex = 1;
            btnToolsEdit.Text = "Edytuj";
            btnToolsEdit.UseVisualStyleBackColor = false;
            btnToolsEdit.Click += btnToolsEdit_Click;
            // 
            // panelTools
            // 
            panelTools.AutoScroll = true;
            panelTools.BorderStyle = BorderStyle.FixedSingle;
            panelTools.Location = new Point(6, 6);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(692, 484);
            panelTools.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(766, 604);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 15;
            label4.Text = "Wersja 0.23";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 604);
            label8.Name = "label8";
            label8.Size = new Size(57, 25);
            label8.TabIndex = 17;
            label8.Text = "COM:";
            // 
            // lblComConnStatus
            // 
            lblComConnStatus.AutoSize = true;
            lblComConnStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblComConnStatus.ForeColor = Color.LightGreen;
            lblComConnStatus.Location = new Point(73, 604);
            lblComConnStatus.Name = "lblComConnStatus";
            lblComConnStatus.Size = new Size(99, 25);
            lblComConnStatus.TabIndex = 18;
            lblComConnStatus.Text = "rozłączony";
            // 
            // lblBTSPPconnStatus
            // 
            lblBTSPPconnStatus.AutoSize = true;
            lblBTSPPconnStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblBTSPPconnStatus.ForeColor = Color.LightGreen;
            lblBTSPPconnStatus.Location = new Point(297, 604);
            lblBTSPPconnStatus.Name = "lblBTSPPconnStatus";
            lblBTSPPconnStatus.Size = new Size(99, 25);
            lblBTSPPconnStatus.TabIndex = 20;
            lblBTSPPconnStatus.Text = "rozłączony";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(212, 604);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 19;
            label9.Text = "BT (SPP):";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(881, 638);
            Controls.Add(lblBTSPPconnStatus);
            Controls.Add(label9);
            Controls.Add(lblComConnStatus);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(tabControl1);
            Controls.Add(btnMinimize);
            Controls.Add(label1);
            Controls.Add(button1);
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
            tabPageCOM.ResumeLayout(false);
            tabPageCOM.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbarThicksCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbarArcTicks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbarPanelOpacity).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            plAlarm.ResumeLayout(false);
            plAlarm.PerformLayout();
            tabTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListCOM;
        private ListBox lbListCOMs;
        private Button btnComConnect;
        private TextBox tbComOutput;
        private CheckBox chbStandardPanel;
        private Label lblBaudRate;
        private TextBox tbCOMBaudrate;
        private Button btnClearLog;
        private Button btnSaveLog;
        private Button button1;
        private Label label1;
        private Button btnMinimize;
        private TabControl tabControl1;
        private TabPage tabPageCOM;
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
        private TrackBar tbarPanelOpacity;
        private Label label5;
        private Label label6;
        private CheckBox cbValueUnder;
        private CheckBox cbValueOver;
        private Panel plAlarm;
        private TextBox tbAlarmUnderValue;
        private Label label7;
        private TabPage tabTools;
        private Button btnToolsRefresh;
        private Button btnToolsEdit;
        private Panel panelTools;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button button2;
        private RadioButton rbCOMparseRaw;
        private RadioButton rbCOMparseLua;
        private RadioButton rbCOMparseStd;
        private Label label8;
        private Label lblComConnStatus;
        private CheckBox chbAdvancedPanel;
        private Label lblBTSPPconnStatus;
        private Label label9;
        private GroupBox groupBox3;
        private TrackBar tbarArcTicks;
        private Label label10;
        private Label lblArcTicks;
        private TrackBar tbarThicksCount;
        private Label label11;
        private Label lblThicksCount;
    }
}
