using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Notepad_DZ
{
    public partial class MainForm : Form
    {
        public static Font dfont; 
        public static string file; 
        public static string messge = " hi notepad Dz is an open source program to \n show how you can use some tools in windose forme \n like textbox and strip menu and outhers .\n this program is by Mohssen Boulahbal :) ";
        public MainForm(string fil= null)
        {
           InitializeComponent();
           file = fil;
        }
        private void AboutNotepToolStripMenuItem_Click(object sender, EventArgs e) => 
            new AboutClone(messge).ShowDialog();

        private void Form1_Load(object sender, EventArgs e)
        {        
            /*dfont  = filedb.Font = Notepad_DZ.Properties.Settings.Default.myFont;
            filedb.Text = null;          
            if (file != null)
            {
                CRUD.path = file; 
                filedb.Text = CRUD.Read();
                CRUD.isaved = true; 
                this.Text = CRUD.name();
            }*/
            // edit stuff

        }
      /*
      *open
      *
      *///
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            if(!CRUD.isaved) 
                /* var sys = new sys("Do you want to save this ?", filedb.Text);  sys.ShowDialog();*/
                //this is better 
                new sys("Do you want to save this ?", filedb.Text).ShowDialog();
                openFileDialog1.ShowDialog();
                CRUD.path = openFileDialog1.FileName;
                filedb.Text = CRUD.Read();               
                this.Text = CRUD.name();
                CRUD.isaved = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) =>
            MainForm.ActiveForm.Close();  
       

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MenuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }


        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CRUD.autosave) CRUD.autosave = false;
            if(CRUD.isaved)
            {
                filedb.Text =
                CRUD.path = null;
                CRUD.isaved = true;                          
                autoSave.Checked = CRUD.autosave;
                this.Text = CRUD.name();
            }
            else
            {
                var sys = new sys("Do you want to save this ?", filedb.Text);
                sys.ShowDialog();
                if (!CRUD.answer)
                {
                    CRUD.isaved = true;
                    CRUD.path = 
                    filedb.Text = null;
                }
            }
            CRUD.answer = true;      
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();        
            dfont = filedb.Font =   Notepad_DZ.Properties.Settings.Default.myFont = fontDialog1.Font;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.Filter = "Html File|*.html| CSS File|*.css| Csharp File|*.cs";
            if (CRUD.path != null && File.Exists(CRUD.path))
                CRUD.Update(filedb.Text);      
            else
            {
                saveFileDialog1.ShowDialog();
                CRUD.path = saveFileDialog1.FileName;
                CRUD.Update(filedb.Text);
            }
            this.Text = CRUD.name();
            CRUD.isaved = true;
        }

        private void Filedb_TextChanged(object sender, EventArgs e)
        {
           //// trap don't gott in 
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            string temp = CRUD.path;
            saveFileDialog1.Title = "Save As"; 
            saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "Html File|*.html| CSS File|*.css| Csharp File|*.cs";
            CRUD.path = saveFileDialog1.FileName;
            CRUD.Update(filedb.Text);
            CRUD.path = temp;
            //this is a pad expertion for us so becuse the CRUD==null return a bool so why are doing this ?       
            //CRUD.isaved = CRUD.path==null?false:true;   // you like the trenery operateor .. :)
            // this is better
            CRUD.isaved = !(CRUD.path == null);

        }

        private void NewWindoseToolStripMenuItem_Click(object sender, EventArgs e) =>
            System.Diagnostics.Process.Start(Environment.CurrentDirectory+ "\\Notepad_DZ.exe");  // so cool
      

        private void FontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
        }

        private void EditeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e) =>
           printDialog1.ShowDialog();
  

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) => e.Graphics.DrawString(CRUD.path, new Font("Tahoma", 18), Brushes.Blue, 10, 20);


        private void PageSetupToolStripMenuItem_Click(object sender, EventArgs e) =>
            pageSetupDialog1.ShowDialog(); 
        
        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void ToolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void WordWarbToolStripMenuItem_Click(object sender, EventArgs e) =>
             filedb.WordWrap =  wordWarbToolStripMenuItem.Checked = !wordWarbToolStripMenuItem.Checked;

        private void StatusToolStripMenuItem_Click(object sender, EventArgs e) =>
             statusStrip1.Visible =  statusToolStripMenuItem.Checked = !statusToolStripMenuItem.Checked;
          
        private void CuteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filedb = this.ActiveControl as TextBox; 
            if(filedb.SelectedText!=string.Empty)     
                Clipboard.SetData(DataFormats.Text , filedb.SelectedText); 
            filedb.SelectedText = string.Empty; 
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filedb = this.ActiveControl as TextBox;
            if (filedb.SelectedText != string.Empty)          
                Clipboard.SetData(DataFormats.Text, filedb.SelectedText);
         
        }

        private void PastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int position = ((TextBox)this.ActiveControl).SelectionStart;
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(position , Clipboard.GetText());
        }

        private void UndoToolStripMenuItem1_Click(object sender, EventArgs e)  =>  filedb.Undo();


        private void DeletToolStripMenuItem_Click(object sender, EventArgs e)  =>
           filedb.SelectedText = (filedb.SelectedText.Length > 0)? string.Empty : filedb.SelectedText;
               
        private void SearchingInBrowserToolStripMenuItem_Click(object sender, EventArgs e) =>  System.Diagnostics.Process.Start($"{filedb.SelectedText}");
    
        // we need to work on this stuff  more about the search algorithem
        private void FindToolStripMenuItem1_Click(object sender, EventArgs e) =>
           new find_in_text(filedb.Text).ShowDialog();
        
        private void FindInTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FindPreviesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // yeah do this please

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e) {
            new Replace(filedb.Text).ShowDialog();
            filedb.Text = CRUD.ttext;
            CRUD.isaved = false;
            filedb.Update();
        } 

        private void GoToToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e) => filedb.SelectAll(); 

        private void TimeDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int position = ((TextBox)this.ActiveControl).SelectionStart;
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(position, DateTime.Now.ToString());
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
          
        }

        private void Form1_FormClosing(object sender , FormClosingEventArgs e )
        {
            if(!CRUD.autosave)
            {
                if (!CRUD.isaved && (CRUD.path != null || filedb.Text.Length > 1))
                {
                    var sys = new sys("Do you want to save this ?", filedb.Text);
                    sys.ShowDialog();
                }         
                e.Cancel = !CRUD.answer;
            }  
        }              
        private void Form1_Click(object sender, EventArgs e)
        {
          
        }

        private void MenuStrip1_Click(object sender, EventArgs e)
        {
            // there is stuff here 
            findToolStripMenuItem1.Enabled =  findInTextToolStripMenuItem.Enabled=findPreviesToolStripMenuItem.Enabled = replaceToolStripMenuItem.Enabled =  filedb.Text.Length > 1;
            // clipord stuff 
            cuteToolStripMenuItem1.Enabled = copyToolStripMenuItem1.Enabled =  deletToolStripMenuItem.Enabled = filedb.SelectedText != string.Empty; 

           // here we go again 
           // do the shit stuff
        }

        private void RundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // work on this undo clear 
        }

        private void Filedb_TextChanged_1(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "          100%";
            toolStripStatusLabel3.Text = $"                          Ln {filedb.Lines.Length} Col {filedb.TextLength}";
            CRUD.ttext = filedb.Text;
            if(CRUD.autosave)
            {
                CRUD.Update(filedb.Text);                                          
                CRUD.isaved = true;
            }
            else 
            CRUD.isaved = false;
        }

        private void AutoSave_Click(object sender, EventArgs e)
        {
            CRUD.autosave = autoSave.Checked = !autoSave.Checked;
            if(CRUD.autosave && CRUD.path==null)
            {
                if(filedb.Text.Length>0)
                {
                    CRUD.ttext = filedb.Text;
                    new anymasseg("you are in save mode creat a file to save what you are working on ").ShowDialog();                   
                    saveFileDialog1.Title = "Creat a file ";
                    saveFileDialog1.ShowDialog();
                    saveFileDialog1.Filter = "Html File|*.html| CSS File|*.css| Csharp File|*.cs";
                    CRUD.path = saveFileDialog1.FileName;
                    this.Text = CRUD.name();
                    CRUD.temp(CRUD.ttext);
                }
                else
                {
                    new message("you are in save mode you need to  creat or open a file ", "do this please ").ShowDialog();
                    if (CRUD.autosave)
                    {
                        this.Text = CRUD.name();
                        filedb.Text = CRUD.ttext;
                    }
                    else
                        autoSave.Checked = CRUD.autosave;
                }             
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ZoomInToolStripMenuItem_Click(object sender, EventArgs e) =>                   
            filedb.Font = new Font(filedb.Font.FontFamily, filedb.Font.Size *1.2f);
   

        private void ZoomOutToolStripMenuItem_Click(object sender, EventArgs e) =>
            filedb.Font = new Font(filedb.Font.FontFamily, filedb.Font.Size / 1.2f);
     

        private void RestoreDefualtZommToolStripMenuItem_Click(object sender, EventArgs e)  =>  filedb.Font = dfont;

        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)=>
            new anymasseg().ShowDialog(); 

        ///System.Diagnostics.Process.Start("shutdown", "/s /t 0");  
       
    }
}
