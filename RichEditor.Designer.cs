namespace ZOYI
{
    partial class RichEditor
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
            rtbEditor = new RichTextBox();
            btnRichEditorSave = new Button();
            btnRichEditorCancel = new Button();
            SuspendLayout();
            // 
            // rtbEditor
            // 
            rtbEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbEditor.Location = new Point(12, 12);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(828, 839);
            rtbEditor.TabIndex = 0;
            rtbEditor.Text = "";
            // 
            // btnRichEditorSave
            // 
            btnRichEditorSave.Anchor = AnchorStyles.Bottom;
            btnRichEditorSave.Location = new Point(201, 880);
            btnRichEditorSave.Name = "btnRichEditorSave";
            btnRichEditorSave.Size = new Size(200, 34);
            btnRichEditorSave.TabIndex = 1;
            btnRichEditorSave.Text = "Zapisz";
            btnRichEditorSave.UseVisualStyleBackColor = true;
            btnRichEditorSave.Click += btnRichEditorSave_Click;
            // 
            // btnRichEditorCancel
            // 
            btnRichEditorCancel.Anchor = AnchorStyles.Bottom;
            btnRichEditorCancel.Location = new Point(449, 880);
            btnRichEditorCancel.Name = "btnRichEditorCancel";
            btnRichEditorCancel.Size = new Size(200, 34);
            btnRichEditorCancel.TabIndex = 2;
            btnRichEditorCancel.Text = "Anuluj";
            btnRichEditorCancel.UseVisualStyleBackColor = true;
            btnRichEditorCancel.Click += btnRichEditorCancel_Click;
            // 
            // RichEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 926);
            Controls.Add(btnRichEditorCancel);
            Controls.Add(btnRichEditorSave);
            Controls.Add(rtbEditor);
            Name = "RichEditor";
            Text = "Editor";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbEditor;
        private Button btnRichEditorSave;
        private Button btnRichEditorCancel;
    }
}