using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyporaPort
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            var text = this.textBoxMarkdown.Text;
            text = Convert(text);
            if(null!= text)
            {
                this.textBoxMarkdown.Text = text;
            }            
        }
        /// <summary>
        /// 对 Typora Markdown 执行转换，转换为 Hugo Markdown。失败返回 Null
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string Convert(string text)
        {
            var pos = LRMatch(text);
            if (pos != -1)
            {
                MessageBox.Show("\\left 和 \\right 的数量不匹配。\n");
                textBoxMarkdown.Select(pos, 1);
                textBoxMarkdown.ScrollToCaret();
                textBoxMarkdown.Focus();
                return null;
            }
            text = Regex.Replace(text, @"\$\$\n*((.|\n)*?)\n*\$\$", delegate (Match match)
            {
                var o = match.Groups[1].Value.Trim();
                return "\n<div>\n$$" + o + "\n$$\n</div>\n";
            });

            text = Regex.Replace(text, @"\$(.*?)\$", delegate (Match match)
            {
                if (match.Groups[1].Value == string.Empty)
                {
                    return "$$";
                }
                //https://xianbai.me/learn-md/article/syntax/blackslash-escapes.html
                string o = EscapeMarkdown(match.Groups[1].Value.Trim());

                return "<span>$" + o + "$</span>";
            });
            return text;
        }

        private static string EscapeMarkdown(string str)
        {
            var list = new string[]{@"\",
                    @"`",
                    @"*",
                    @"_",
                    @"{",
                    @"}",
                    @"[",
                    @"]",
                    @"(",
                    @")",
                    @"#",
                    @"+",
                    @"-",
                    @".",
                    @"!",};
            var tmp = str;
            foreach (var c in list)
            {
                tmp = tmp.Replace(c, "\\" + c);
            }
            return tmp;
                            //.Replace("_", @"\_")
                            //.Replace("*", @"\*")
                            //.Replace("|", @"\|")
                            //.Replace("\\left(", @"(")
                            //.Replace("\\right)", @")")
                            //.Replace("\\left[", @"[")
                            //.Replace("\\right]", @"]")
                            //.Replace("\\left{", @"\\{")
                            //.Replace("\\right}", @"\\}")
                            //.Replace("\\left", @"")
                            //.Replace("\\right", @"");
        }

        private int LRMatch(string text)
        {
            var tmp =
            text.Replace("{", "<")
            .Replace("}", ">")
            .Replace("\\leftarrow", "     arrow")
            .Replace("\\rightarrow", "      arrow")
             .Replace("\\Leftarrow", "     arrow")
            .Replace("\\Rightarrow", "      arrow")
            .Replace("\\left", "{    ")
            .Replace("\\right", "     }");

            int counter = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == '{')
                {
                    counter++;
                }
                if (tmp[i] == '}')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    return i;
                }
            }
            if (counter != 0)
            {
                return tmp.Length - 1;
            }
            else
            {
                return -1;
            }

        }

        private void buttonTitleDown_Click(object sender, EventArgs e)
        {
            var text = this.textBoxMarkdown.Text;
            // 特殊情况懒得处理了，不常见
            text = "\n" + text;
            text = text.Replace("\n## ", "\n# ");
            text = text.Replace("\n### ", "\n## ");
            text = text.Replace("\n#### ", "\n### ");
            text = text.Replace("\n##### ", "\n#### ");
            text = text.Replace("\n###### ", "\n##### ");
            this.textBoxMarkdown.Text = text.Substring(1);

        }

        private void textBoxOutputDir_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(textBoxOutputDir.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var tmp  = Application.StartupPath + "/output";
            System.IO.Directory.CreateDirectory(tmp);
            textBoxOutputDir.Text = tmp;
        }
    }
}
