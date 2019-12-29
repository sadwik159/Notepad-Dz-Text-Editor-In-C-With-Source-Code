namespace Notepad_DZ
{
    partial class sys
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
            this.butok = new System.Windows.Forms.Button();
            this.butNo = new System.Windows.Forms.Button();
            this.butCant = new System.Windows.Forms.Button();
            this.messag = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // butok
            // 
            this.butok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butok.BackColor = System.Drawing.Color.Transparent;
            this.butok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butok.Location = new System.Drawing.Point(62, 68);
            this.butok.Margin = new System.Windows.Forms.Padding(0);
            this.butok.Name = "butok";
            this.butok.Size = new System.Drawing.Size(67, 26);
            this.butok.TabIndex = 0;
            this.butok.Text = "Ok";
            this.butok.UseVisualStyleBackColor = false;
            this.butok.Click += new System.EventHandler(this.Butok_Click);
            // 
            // butNo
            // 
            this.butNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butNo.BackColor = System.Drawing.Color.Transparent;
            this.butNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butNo.Location = new System.Drawing.Point(176, 68);
            this.butNo.Margin = new System.Windows.Forms.Padding(0);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(67, 26);
            this.butNo.TabIndex = 1;
            this.butNo.Text = "No";
            this.butNo.UseVisualStyleBackColor = false;
            this.butNo.Click += new System.EventHandler(this.ButNo_Click);
            // 
            // butCant
            // 
            this.butCant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butCant.BackColor = System.Drawing.Color.Transparent;
            this.butCant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butCant.Location = new System.Drawing.Point(287, 68);
            this.butCant.Margin = new System.Windows.Forms.Padding(0);
            this.butCant.Name = "butCant";
            this.butCant.Size = new System.Drawing.Size(67, 26);
            this.butCant.TabIndex = 2;
            this.butCant.Text = "Cancel";
            this.butCant.UseVisualStyleBackColor = false;
            this.butCant.Click += new System.EventHandler(this.ButCant_Click);
            // 
            // messag
            // 
            this.messag.AutoSize = true;
            this.messag.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messag.Location = new System.Drawing.Point(131, 32);
            this.messag.Name = "messag";
            this.messag.Size = new System.Drawing.Size(37, 16);
            this.messag.TabIndex = 3;
            this.messag.Text = "msg";
            this.messag.Click += new System.EventHandler(this.Messag_Click);
            // 
            // sys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 141);
            this.Controls.Add(this.messag);
            this.Controls.Add(this.butCant);
            this.Controls.Add(this.butNo);
            this.Controls.Add(this.butok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sys";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Do you want to save you shit ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sys_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sys_FormClosed);
            this.Load += new System.EventHandler(this.Sys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butok;
        private System.Windows.Forms.Button butNo;
        private System.Windows.Forms.Button butCant;
        private System.Windows.Forms.Label messag;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}