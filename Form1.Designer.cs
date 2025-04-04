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
            listBox1 = new ListBox();
            btnConnect = new Button();
            label1 = new Label();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // btnListCOM
            // 
            btnListCOM.Location = new Point(208, 12);
            btnListCOM.Name = "btnListCOM";
            btnListCOM.Size = new Size(129, 34);
            btnListCOM.TabIndex = 1;
            btnListCOM.Text = "Pokaż porty";
            btnListCOM.UseVisualStyleBackColor = true;
            btnListCOM.Click += btnListCOM_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(377, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(112, 34);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Połącz";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 418);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(517, 18);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(271, 420);
            txtOutput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOutput);
            Controls.Add(label1);
            Controls.Add(btnConnect);
            Controls.Add(listBox1);
            Controls.Add(btnListCOM);
            Name = "Form1";
            Text = "ZOYI Terminal";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListCOM;
        private ListBox listBox1;
        private Button btnConnect;
        private Label label1;
        private TextBox txtOutput;
    }
}
