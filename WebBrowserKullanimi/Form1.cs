using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("www.google.com");
        }

        private void Btn_git_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_ara.Text))
            {
                webBrowser1.Navigate(tb_ara.Text);
            }
        }

        private void Tb_ara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(tb_ara.Text);
            }
        }

        private void Btn_geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tb_ara.Text = e.Url.ToString();
        }

        private void Btn_ileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Btn_yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tb_ara.Text);
        }
    }
}
