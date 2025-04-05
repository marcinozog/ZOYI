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
            btnConnect.Location = new Point(12, 212);
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
            txtOutput.Size = new Size(271, 420);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chbShowPanel);
            Controls.Add(txtOutput);
            Controls.Add(btnConnect);
            Controls.Add(lbCOMs);
            Controls.Add(btnListCOM);
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
    }
}
