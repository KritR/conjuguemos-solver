using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using spanishsolver;
using mshtml;

namespace spanishsolver
{
    public partial class FormInjectScript : Form
    {
        public static spanishsolverForm spanishSolverF { get; set; }
        public FormInjectScript()
        {
            InitializeComponent();
        }

        private void buttonInject_Click(object sender, EventArgs e)
        {
            webBrowserInjectElement.text = "function injectElement() {" + textBoxInject.Text + "}";
            webBrowserInjectHead.AppendChild(webBrowserInjectScriptEL);
            textBoxInject.Text = "";
            richTextBoxOutput.Text = richTextBoxOutput.Text + "\n" + webBrowserInjectElement.text;
            spanishSolverF.invokeScript();
        }
        public static HtmlElement webBrowserInjectHead { get; set; }
        public static HtmlElement webBrowserInjectScriptEL { get; set; }
        public static IHTMLScriptElement webBrowserInjectElement{ get; set; }
        public static object webBrowserInjectInvoke { get; set; }

        private void richTextBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
