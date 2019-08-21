namespace Client_Final
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.savefile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newfile = new System.Windows.Forms.Button();
            this.loadfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.createfile = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openfile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.closefile = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(25, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(597, 541);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // savefile
            // 
            this.savefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.savefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savefile.ForeColor = System.Drawing.Color.White;
            this.savefile.Location = new System.Drawing.Point(647, 28);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(103, 47);
            this.savefile.TabIndex = 8;
            this.savefile.Text = "Save File";
            this.savefile.UseVisualStyleBackColor = false;
            this.savefile.Visible = false;
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.newfile);
            this.groupBox2.Controls.Add(this.loadfile);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(397, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 179);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newfile
            // 
            this.newfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newfile.ForeColor = System.Drawing.Color.White;
            this.newfile.Location = new System.Drawing.Point(19, 118);
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(103, 47);
            this.newfile.TabIndex = 5;
            this.newfile.Text = "New File";
            this.newfile.UseVisualStyleBackColor = false;
            this.newfile.Click += new System.EventHandler(this.newfile_Click);
            // 
            // loadfile
            // 
            this.loadfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadfile.ForeColor = System.Drawing.Color.White;
            this.loadfile.Location = new System.Drawing.Point(19, 65);
            this.loadfile.Name = "loadfile";
            this.loadfile.Size = new System.Drawing.Size(103, 47);
            this.loadfile.TabIndex = 4;
            this.loadfile.Text = "Load File";
            this.loadfile.UseVisualStyleBackColor = false;
            this.loadfile.Click += new System.EventHandler(this.loadfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(352, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 196);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(26, 119);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(171, 44);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(170, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.createfile);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(352, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 187);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 12;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 26);
            this.textBox3.TabIndex = 3;
            // 
            // createfile
            // 
            this.createfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createfile.ForeColor = System.Drawing.Color.White;
            this.createfile.Location = new System.Drawing.Point(28, 105);
            this.createfile.Name = "createfile";
            this.createfile.Size = new System.Drawing.Size(170, 47);
            this.createfile.TabIndex = 7;
            this.createfile.Text = "Create File";
            this.createfile.UseVisualStyleBackColor = false;
            this.createfile.Click += new System.EventHandler(this.createfile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.back);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.openfile);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(647, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 413);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(66, 348);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(105, 47);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "text";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openfile
            // 
            this.openfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openfile.ForeColor = System.Drawing.Color.White;
            this.openfile.Location = new System.Drawing.Point(33, 295);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(168, 47);
            this.openfile.TabIndex = 7;
            this.openfile.Text = "Open File";
            this.openfile.UseVisualStyleBackColor = false;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(33, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 224);
            this.listBox1.TabIndex = 6;
            // 
            // closefile
            // 
            this.closefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.closefile.ForeColor = System.Drawing.Color.White;
            this.closefile.Location = new System.Drawing.Point(776, 28);
            this.closefile.Name = "closefile";
            this.closefile.Size = new System.Drawing.Size(103, 47);
            this.closefile.TabIndex = 7;
            this.closefile.Text = "Close File";
            this.closefile.UseVisualStyleBackColor = false;
            this.closefile.Visible = false;
            this.closefile.Click += new System.EventHandler(this.closefile_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(680, 522);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(168, 47);
            this.logout.TabIndex = 10;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Visible = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(908, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.closefile);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "File Editor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button savefile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newfile;
        private System.Windows.Forms.Button loadfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button createfile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button closefile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label5;
    }
}

