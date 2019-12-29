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
    public partial class Replace : Form
    {
        public string text; 
        public Replace(string text )
        {
            this.text = text; 
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Replacebutton_Click(object sender, EventArgs e)
        {
            Notepad_DZ.CRUD.ttext = trytoclone.patr.Findandreplace(Notepad_DZ.CRUD.ttext, findthat.Text, replacewith.Text);
        }  
        private void Reaplaceall_Click(object sender, EventArgs e)
        {
             Notepad_DZ.CRUD.ttext = trytoclone.patr.Findandreplace(Notepad_DZ.CRUD.ttext, findthat.Text, replacewith.Text);
        }

        private void findthat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
