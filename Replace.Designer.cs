namespace Notepad_DZ
{
    partial class Replace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.findthat = new System.Windows.Forms.TextBox();
            this.Findnext = new System.Windows.Forms.Button();
            this.Matchcase = new System.Windows.Forms.CheckBox();
            this.Warparound = new System.Windows.Forms.CheckBox();
            this.Replacebutton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Reaplaceall = new System.Windows.Forms.Button();
            this.replacewith = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Find what : ";
            // 
            // findthat
            // 
            this.findthat.Location = new System.Drawing.Point(89, 14);
            this.findthat.Name = "findthat";
            this.findthat.Size = new System.Drawing.Size(192, 20);
            this.findthat.TabIndex = 1;
            this.findthat.TextChanged += new System.EventHandler(this.findthat_TextChanged);
            // 
            // Findnext
            // 
            this.Findnext.Location = new System.Drawing.Point(287, 12);
            this.Findnext.Name = "Findnext";
            this.Findnext.Size = new System.Drawing.Size(72, 22);
            this.Findnext.TabIndex = 5;
            this.Findnext.Text = "Find Next";
            this.Findnext.UseVisualStyleBackColor = true;
            // 
            // Matchcase
            // 
            this.Matchcase.AutoSize = true;
            this.Matchcase.Location = new System.Drawing.Point(5, 74);
            this.Matchcase.Name = "Matchcase";
            this.Matchcase.Size = new System.Drawing.Size(82, 17);
            this.Matchcase.TabIndex = 6;
            this.Matchcase.Text = "Match case";
            this.Matchcase.UseVisualStyleBackColor = true;
            // 
            // Warparound
            // 
            this.Warparound.AutoSize = true;
            this.Warparound.Location = new System.Drawing.Point(5, 97);
            this.Warparound.Name = "Warparound";
            this.Warparound.Size = new System.Drawing.Size(88, 17);
            this.Warparound.TabIndex = 7;
            this.Warparound.Text = "Wrap around";
            this.Warparound.UseVisualStyleBackColor = true;
            // 
            // Replacebutton
            // 
            this.Replacebutton.Location = new System.Drawing.Point(287, 40);
            this.Replacebutton.Name = "Replacebutton";
            this.Replacebutton.Size = new System.Drawing.Size(72, 22);
            this.Replacebutton.TabIndex = 8;
            this.Replacebutton.Text = "Replace";
            this.Replacebutton.UseVisualStyleBackColor = true;
            this.Replacebutton.Click += new System.EventHandler(this.Replacebutton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(287, 94);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(72, 22);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Reaplaceall
            // 
            this.Reaplaceall.Location = new System.Drawing.Point(287, 66);
            this.Reaplaceall.Name = "Reaplaceall";
            this.Reaplaceall.Size = new System.Drawing.Size(72, 22);
            this.Reaplaceall.TabIndex = 9;
            this.Reaplaceall.Text = "Replace all";
            this.Reaplaceall.UseVisualStyleBackColor = true;
            this.Reaplaceall.Click += new System.EventHandler(this.Reaplaceall_Click);
            // 
            // replacewith
            // 
            this.replacewith.Location = new System.Drawing.Point(89, 37);
            this.replacewith.Name = "replacewith";
            this.replacewith.Size = new System.Drawing.Size(192, 20);
            this.replacewith.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Replace with:";
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.replacewith);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Reaplaceall);
            this.Controls.Add(this.Replacebutton);
            this.Controls.Add(this.Warparound);
            this.Controls.Add(this.Matchcase);
            this.Controls.Add(this.Findnext);
            this.Controls.Add(this.findthat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Replace";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace";
            this.Load += new System.EventHandler(this.Find_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findthat;
        private System.Windows.Forms.Button Findnext;
        private System.Windows.Forms.CheckBox Matchcase;
        private System.Windows.Forms.CheckBox Warparound;
        private System.Windows.Forms.Button Replacebutton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Reaplaceall;
        private System.Windows.Forms.TextBox replacewith;
        private System.Windows.Forms.Label label2;
    }
}