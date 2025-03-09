namespace GitGGM
{
    partial class Clone
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
            this.Folderpath = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Pushbtn = new System.Windows.Forms.Button();
            this.Commitbtn = new System.Windows.Forms.Button();
            this.txtCommitMessage = new System.Windows.Forms.TextBox();
            this.FolderNameWrite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Folderpath
            // 
            this.Folderpath.Location = new System.Drawing.Point(163, 131);
            this.Folderpath.Name = "Folderpath";
            this.Folderpath.Size = new System.Drawing.Size(446, 21);
            this.Folderpath.TabIndex = 0;
            this.Folderpath.TextChanged += new System.EventHandler(this.Folderpath_TextChanged);
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(163, 104);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(446, 21);
            this.URL.TabIndex = 0;
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "파일찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Folderpath_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clone";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clonebntn_Click);
            // 
            // Pushbtn
            // 
            this.Pushbtn.Location = new System.Drawing.Point(408, 227);
            this.Pushbtn.Name = "Pushbtn";
            this.Pushbtn.Size = new System.Drawing.Size(75, 23);
            this.Pushbtn.TabIndex = 3;
            this.Pushbtn.Text = "Push";
            this.Pushbtn.UseVisualStyleBackColor = true;
            this.Pushbtn.Click += new System.EventHandler(this.Pushbtn_Click);
            // 
            // Commitbtn
            // 
            this.Commitbtn.Location = new System.Drawing.Point(534, 227);
            this.Commitbtn.Name = "Commitbtn";
            this.Commitbtn.Size = new System.Drawing.Size(75, 23);
            this.Commitbtn.TabIndex = 4;
            this.Commitbtn.Text = "Commit";
            this.Commitbtn.UseVisualStyleBackColor = true;
            this.Commitbtn.Click += new System.EventHandler(this.Commitbtn_Click);
            // 
            // txtCommitMessage
            // 
            this.txtCommitMessage.Location = new System.Drawing.Point(163, 185);
            this.txtCommitMessage.Name = "txtCommitMessage";
            this.txtCommitMessage.Size = new System.Drawing.Size(446, 21);
            this.txtCommitMessage.TabIndex = 5;
            // 
            // FolderNameWrite
            // 
            this.FolderNameWrite.Location = new System.Drawing.Point(163, 158);
            this.FolderNameWrite.Name = "FolderNameWrite";
            this.FolderNameWrite.Size = new System.Drawing.Size(446, 21);
            this.FolderNameWrite.TabIndex = 6;
            this.FolderNameWrite.TextChanged += new System.EventHandler(this.FolderNameWrite_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FolderNameWrite);
            this.Controls.Add(this.txtCommitMessage);
            this.Controls.Add(this.Commitbtn);
            this.Controls.Add(this.Pushbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Folderpath);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Folderpath;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Pushbtn;
        private System.Windows.Forms.Button Commitbtn;
        private System.Windows.Forms.TextBox txtCommitMessage;
        private System.Windows.Forms.TextBox FolderNameWrite;
    }
}