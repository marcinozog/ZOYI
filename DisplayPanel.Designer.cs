namespace ZOYI
{
    partial class DisplayPanel
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
            SuspendLayout();
            // 
            // lblLabel
            // 
            lblLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLabel.Location = new Point(60, 13);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(260, 80);
            lblLabel.TabIndex = 0;
            lblLabel.Text = "Capacity";
            lblLabel.TextAlign = ContentAlignment.MiddleCenter;
            lblLabel.MouseDoubleClick += DisplayPanel_MouseDoubleClick;
            lblLabel.MouseDown += FormPanel_MouseDown;
            lblLabel.MouseMove += FormPanel_MouseMove;
            lblLabel.MouseUp += FormPanel_MouseUp;
            // 
            // lblValue
            // 
            lblValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValue.Location = new Point(60, 100);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(260, 80);
            lblValue.TabIndex = 1;
            lblValue.Text = "100uF";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
            lblValue.MouseDoubleClick += DisplayPanel_MouseDoubleClick;
            lblValue.MouseDown += FormPanel_MouseDown;
            lblValue.MouseMove += FormPanel_MouseMove;
            lblValue.MouseUp += FormPanel_MouseUp;
            // 
            // DisplayPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(385, 192);
            Controls.Add(lblValue);
            Controls.Add(lblLabel);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayPanel";
            Text = "FormPanel";
            MouseDoubleClick += DisplayPanel_MouseDoubleClick;
            MouseDown += FormPanel_MouseDown;
            MouseMove += FormPanel_MouseMove;
            MouseUp += FormPanel_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Label lblLabel;
        private Label lblValue;
    }
}