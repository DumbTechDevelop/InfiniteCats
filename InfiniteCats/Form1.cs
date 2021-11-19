using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfiniteCats
{
    public partial class InfiniteCats : Form
    
    {
        public InfiniteCats()
        {
            InitializeComponent();
        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://www.thiscatdoesnotexist.com/");
        }
    }
}
