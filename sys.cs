using System;
using System.IO;
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
    public partial class sys : Form
    {
        private string msg , text;
        public sys(string msg ,string text = "Save"  )
        {
            InitializeComponent();
            this.msg = msg;
            this.text = text;  
        }

        public sys()
        {
        }

        private void Butok_Click(object sender, EventArgs e)
        {                       
            CRUD.answer = true;
            dothis();
            this.Close();
        }

        private void ButNo_Click(object sender, EventArgs e)
        {
            CRUD.answer = true; 
            this.Close();
        }

        private void ButCant_Click(object sender, EventArgs e)
        {
            CRUD.answer = false;
            this.Close();
        }

        private void Sys_Load(object sender, EventArgs e)
        {
            messag.Text = this.msg;
        }

        private void Sys_FormClosing(object sender, FormClosingEventArgs e)
        {
          
       
        }
        private void dothis ()
        {
                if (CRUD.path != null && File.Exists(CRUD.path))
                    CRUD.Update(text);          
                else
                {
                    saveFileDialog1.ShowDialog();
                    CRUD.path = saveFileDialog1.FileName;
                    CRUD.Update(text);
                }          
        }
        private void Messag_Click(object sender, EventArgs e)
        {

        }

        private void Sys_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
