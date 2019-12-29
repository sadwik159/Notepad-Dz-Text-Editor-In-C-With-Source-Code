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
    public partial class message : Form
    {
        string msg; 
        public message(string msg , string title)
        {
            InitializeComponent();
            this.msg = msg;
            this.Text = title;
        }

        private void Message_Load(object sender, EventArgs e)
        {
            label1.Text = msg;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open a file ";
            openFileDialog1.ShowDialog();
            CRUD.path = openFileDialog1.FileName;
            CRUD.ttext = CRUD.Read();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CRUD.autosave = false;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Creat a file ";
            saveFileDialog1.ShowDialog();
            CRUD.path = saveFileDialog1.FileName;
            CRUD.Update(null);
            this.Close();
        }
    }
}
