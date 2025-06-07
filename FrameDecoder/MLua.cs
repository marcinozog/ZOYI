using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLua;

namespace ZOYI
{
    public class MLua
    {
        Lua? lua;
        LuaFunction? luaFunc;
        string? luaPath;

        private readonly string[] luaKeywords = new string[]
        {
            "and", "break", "do", "else", "elseif", "end", "false", "for", "function",
            "if", "in", "local", "nil", "not", "or", "repeat", "return", "then", "true",
            "until", "while"
        };

        /*
         * LuaLoad(string path)
         */
        private void LuaLoad(string path)
        {
            luaPath = path;
            lua = new Lua();
            lua.State.Encoding = Encoding.UTF8;
            lua.DoFile(luaPath);
            luaFunc = (LuaFunction)lua["parseLabelValueSuffix_LUA"];
        }

        /*
         * LuaReload(string path)
         */
        public void LuaReload(string path)
        {
            luaFunc?.Dispose();
            luaFunc = null!;
            lua?.Dispose();
            lua = null!;

            LuaLoad(path);
        }

        /*
         * lua_parse_label_value_suffix(string buff)
         */
        public string[] parseLabelValueSuffix_LUA(string buff)
        {
            string[] ret = new string[3];
            int i = 0;

            try
            {
                object[] result = luaFunc!.Call(buff);
                LuaTable? table = result[0] as LuaTable;

                foreach (var val in table!.Values)
                {
                    ret[i] = val.ToString()!;
                    i++;
                }
            }
            catch (Exception) { }

            return ret;
        }

        /*
         * luaHighlight(string code, RichTextBox rtbEditor)
         */
        public void luaHighlightRichTextBox(string code, RichTextBox rtbEditor)
        {
            rtbEditor.Text = code;
            rtbEditor.SelectAll();
            rtbEditor.SelectionColor = Color.Black;

            // comments
            luaHighlightPattern(@"--.*", Color.Green, rtbEditor);

            // strings
            luaHighlightPattern(@"""[^""]*""", Color.Brown, rtbEditor);     // ""
            luaHighlightPattern(@"'[^']*'", Color.Brown, rtbEditor);        // ''

            // keywords
            foreach (string keyword in luaKeywords)
            {
                luaHighlightPattern(@"\b" + keyword + @"\b", Color.Blue, rtbEditor);
            }
        }

        /*
         * luaHighlightPattern(string pattern, Color color, RichTextBox rtbEditor)
         */
        private void luaHighlightPattern(string pattern, Color color, RichTextBox rtbEditor, RegexOptions options = RegexOptions.Singleline)
        {
            foreach (Match match in Regex.Matches(rtbEditor.Text, pattern, options))
            {
                rtbEditor.Select(match.Index, match.Length);
                rtbEditor.SelectionColor = color;
            }
        }
    }
}
