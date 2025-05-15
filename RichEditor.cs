using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOYI
{
    public partial class RichEditor : Form
    {
        public enum ENCODING
        {
            LUA = 0,
            TOOLS
        }

        MLua? mLua;
        Tools? tools;

        private string filePath = "";
        private TaskCompletionSource<string>? tcsAsyncEdit;

        /*
         * RichEditor(Tools tools)
         */
        public RichEditor(Tools tools)
        {
            InitializeComponent();
            this.tools = tools;
        }

        /*
         * RichEditor(MLua mlua)
         */
        public RichEditor(MLua mlua)
        {
            InitializeComponent();
            this.mLua = mlua;
        }

        /*
         * setText(string text, ENCODING enc)
         */
        public void setText(string text, ENCODING enc)
        {
            switch (enc)
            {
                case ENCODING.LUA:
                    mLua!.luaHighlightRichTextBox(text, rtbEditor);
                    break;
                case ENCODING.TOOLS:
                    rtbEditor.Text = text;
                    break;
                default:
                    rtbEditor.Text = text;
                    break;
            }

            rtbEditor.SelectionStart = 0;
        }

        /*
         * loadFile(string path, ENCODING enc)
         */
        public void loadFile(string path, ENCODING enc)
        {
            filePath = path;
            string text = File.ReadAllText(filePath);
            this.Text = path;
            setText(text, enc);
        }

        /*
         * btnRichEditorSave_Click(object sender, EventArgs e)
         */
        private void btnRichEditorSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, rtbEditor.Text);
            tcsAsyncEdit!.SetResult("save");
            this.Close();
        }

        /*
         * btnRichEditorCancel_Click(object sender, EventArgs e)
         */
        private void btnRichEditorCancel_Click(object sender, EventArgs e)
        {
            tcsAsyncEdit!.SetResult("cancel");
            this.Close();
        }

        /*
         * AsyncEdit()
         */
        public Task<string> AsyncEdit()
        {
            tcsAsyncEdit = new TaskCompletionSource<string>();
            this.FormClosed += (s, e) =>
            {
                if (!tcsAsyncEdit.Task.IsCompleted)
                    tcsAsyncEdit.SetResult("cancel");
            };
            this.Show();
            return tcsAsyncEdit.Task;
        }
    }
}
