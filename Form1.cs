using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class Simple : Form
    {
        public Simple()
        {
            InitializeComponent();
        }
        //dont touch
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// when the exit item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser was made by a cat");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //navigate go button
        private void Go_Click(object sender, EventArgs e)
        {
         
            navigate();

        }
        //core funtion that will perferm all navigation and apost processing
        private void navigate()
        {

       
            webBrowser1.Navigate(textBox1.Text);
            textBox1.Enabled = false;
            Go.Enabled = false;
       
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)ConsoleKey.Enter)
            {
                navigate();

   
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Go.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Navigation COmplete";

            foreach (HtmlElement image in webBrowser1.Document.Images)

                image.SetAttribute("src", "http://static.flickr.com/34/122530930_6e16f1eb5c.jpg");

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)

        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0 )
            {

                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress / 100 / e.MaximumProgress);
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
} 

