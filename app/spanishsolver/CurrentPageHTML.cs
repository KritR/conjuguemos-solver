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

namespace spanishsolver
{
    public partial class CurrentPageHTML : Form
    {
        public CurrentPageHTML()
        {
            InitializeComponent();
        }

        private void CurrentPageHTML_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = webBrowserHTML;
        }

        public static string webBrowserHTML { get; set; }
    }
}
