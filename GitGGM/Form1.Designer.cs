namespace GitGGM
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.ProjectText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizebtn = new System.Windows.Forms.Button();
            this.Maximizebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ProjectPanel.Location = new System.Drawing.Point(3, 59);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(300, 605);
            this.ProjectPanel.TabIndex = 0;
            this.ProjectPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProjectPanel_Paint);
            // 
            // ProjectText
            // 
            this.ProjectText.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProjectText.ForeColor = System.Drawing.Color.FloralWhite;
            this.ProjectText.Location = new System.Drawing.Point(0, 31);
            this.ProjectText.Name = "ProjectText";
            this.ProjectText.Size = new System.Drawing.Size(300, 25);
            this.ProjectText.TabIndex = 1;
            this.ProjectText.Text = "Projcets";
            this.ProjectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProjectText.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.Minimizebtn);
            this.panel1.Controls.Add(this.Maximizebtn);
            this.panel1.Controls.Add(this.Exitbtn);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 35);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Titlebar_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // Minimizebtn
            // 
            this.Minimizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Minimizebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Minimizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizebtn.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minimizebtn.ForeColor = System.Drawing.Color.White;
            this.Minimizebtn.Location = new System.Drawing.Point(1316, 0);
            this.Minimizebtn.Name = "Minimizebtn";
            this.Minimizebtn.Size = new System.Drawing.Size(35, 35);
            this.Minimizebtn.TabIndex = 2;
            this.Minimizebtn.Text = "-";
            this.Minimizebtn.UseVisualStyleBackColor = false;
            this.Minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click);
            // 
            // Maximizebtn
            // 
            this.Maximizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Maximizebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Maximizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximizebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Maximizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximizebtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Maximizebtn.ForeColor = System.Drawing.Color.White;
            this.Maximizebtn.Location = new System.Drawing.Point(1351, 0);
            this.Maximizebtn.Name = "Maximizebtn";
            this.Maximizebtn.Size = new System.Drawing.Size(35, 35);
            this.Maximizebtn.TabIndex = 1;
            this.Maximizebtn.Text = "□";
            this.Maximizebtn.UseVisualStyleBackColor = false;
            this.Maximizebtn.Click += new System.EventHandler(this.Maximizebtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exitbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exitbtn.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.Location = new System.Drawing.Point(1386, 0);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(35, 35);
            this.Exitbtn.TabIndex = 0;
            this.Exitbtn.Text = "X";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(309, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 605);
            this.panel2.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(661, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(82, 21);
            this.Title.TabIndex = 0;
            this.Title.Text = "GitGGM";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(733, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ProjectName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1424, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProjectText);
            this.Controls.Add(this.ProjectPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "GitGGM";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.Label ProjectText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Minimizebtn;
        private System.Windows.Forms.Button Maximizebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
    }
}

