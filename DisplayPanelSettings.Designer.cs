namespace ZOYI
{
    partial class DisplayPanelSettings
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
            btnColorBg = new Button();
            btnColorLabel = new Button();
            chbAlarm = new CheckBox();
            btnColorValue = new Button();
            tbAlarmLabel = new TextBox();
            tbAlarmValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnColorBg
            // 
            btnColorBg.BackColor = SystemColors.Desktop;
            btnColorBg.Location = new Point(11, 14);
            btnColorBg.Name = "btnColorBg";
            btnColorBg.Size = new Size(142, 34);
            btnColorBg.TabIndex = 0;
            btnColorBg.Text = "Kolor tła";
            btnColorBg.UseVisualStyleBackColor = false;
            // 
            // btnColorLabel
            // 
            btnColorLabel.BackColor = SystemColors.Desktop;
            btnColorLabel.Location = new Point(11, 54);
            btnColorLabel.Name = "btnColorLabel";
            btnColorLabel.Size = new Size(141, 34);
            btnColorLabel.TabIndex = 1;
            btnColorLabel.Text = "Kolor etykiety";
            btnColorLabel.UseVisualStyleBackColor = false;
            // 
            // chbAlarm
            // 
            chbAlarm.AutoSize = true;
            chbAlarm.Location = new Point(194, 14);
            chbAlarm.Name = "chbAlarm";
            chbAlarm.Size = new Size(85, 29);
            chbAlarm.TabIndex = 2;
            chbAlarm.Text = "Alarm";
            chbAlarm.UseVisualStyleBackColor = true;
            // 
            // btnColorValue
            // 
            btnColorValue.BackColor = SystemColors.Desktop;
            btnColorValue.Location = new Point(11, 94);
            btnColorValue.Name = "btnColorValue";
            btnColorValue.Size = new Size(142, 34);
            btnColorValue.TabIndex = 3;
            btnColorValue.Text = "Kolor wartości";
            btnColorValue.UseVisualStyleBackColor = false;
            // 
            // tbAlarmLabel
            // 
            tbAlarmLabel.Location = new Point(291, 56);
            tbAlarmLabel.Name = "tbAlarmLabel";
            tbAlarmLabel.Size = new Size(150, 31);
            tbAlarmLabel.TabIndex = 4;
            // 
            // tbAlarmValue
            // 
            tbAlarmValue.Location = new Point(291, 94);
            tbAlarmValue.Name = "tbAlarmValue";
            tbAlarmValue.Size = new Size(150, 31);
            tbAlarmValue.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(194, 59);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 6;
            label1.Text = "Etykieta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(194, 99);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 7;
            label2.Text = "Wartość:";
            // 
            // DisplayPanelSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(458, 159);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbAlarmValue);
            Controls.Add(tbAlarmLabel);
            Controls.Add(btnColorValue);
            Controls.Add(chbAlarm);
            Controls.Add(btnColorLabel);
            Controls.Add(btnColorBg);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DisplayPanelSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DisplayPanelSettings";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnColorBg;
        private Button btnColorLabel;
        private CheckBox chbAlarm;
        private Button btnColorValue;
        private TextBox tbAlarmLabel;
        private TextBox tbAlarmValue;
        private Label label1;
        private Label label2;
    }
}