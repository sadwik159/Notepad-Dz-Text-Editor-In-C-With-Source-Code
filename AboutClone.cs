using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_DZ
{
    public partial class AboutClone : Form
    {
        string msg;
        public AboutClone(string msg)
        {
            InitializeComponent();
            this.msg = msg; 
        }

        private void AboutClone_Load(object sender, EventArgs e)
        {
            massegin.Text = msg;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
