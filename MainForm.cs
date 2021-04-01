using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Browser_Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All right Reserved with Ali Tech 2020-2021",
                "About  Ali Web Brwser ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WebBrowsers.Navigate("https://www.google.co.in");
        }

        private void HomeToolStripButton_Click(object sender, EventArgs e)
        {
            WebBrowsers.Navigate("https://www.google.co.in");
        }

        private void GoToolStripButton_Click(object sender, EventArgs e)
        {
            WebBrowsers.Navigate(SearchToolStripComboBox.Text);
        }

        private void SearchToolStripComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowsers.Navigate(SearchToolStripComboBox.Text);
            }
        }
    }
}
