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
    public partial class find_in_text : Form
    {
        string text;
        public find_in_text(string text )
        {
            InitializeComponent();
            this.text = text;
        }

        private void Find_in_text_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"you have {numberofmatches(text, textBox1.Text)} match");
         }
        public static int numberofmatches(string text, string find)
        {
            int count = 0;
            List<string> hi = text.Split().ToList<string>();
            for (int i = 0; i < hi.Count; i++) if (hi[i] == find) count++;
            return count;
        }
    }
}
