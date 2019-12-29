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
    public partial class anymasseg   : Form
    {
        string msg; 
        public anymasseg(string msg  )
        {
            InitializeComponent();
            this.msg = msg;
        }

        public anymasseg()
        {
        }

        private void About_Load(object sender, EventArgs e)
        {
            massegin.Text = msg; 
        }

        private void Massegin_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
