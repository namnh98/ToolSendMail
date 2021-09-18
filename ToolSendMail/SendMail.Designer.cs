namespace ToolSendMail
{
    partial class SendMail
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
            this.pnAttachFIle = new System.Windows.Forms.Panel();
            this.attachFilebtn = new System.Windows.Forms.Button();
            this.attachtxb = new System.Windows.Forms.TextBox();
            this.pnToMail = new System.Windows.Forms.Panel();
            this.attachListMailbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totxb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.subjecttxb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametxb = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAttachMessageMail = new System.Windows.Forms.Button();
            this.messagetxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendbtn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbToMail = new System.Windows.Forms.CheckBox();
            this.cbToListMail = new System.Windows.Forms.CheckBox();
            this.cbAttachedFile = new System.Windows.Forms.CheckBox();
            this.cbAttachedMessage = new System.Windows.Forms.CheckBox();
            this.pnAttachFIle.SuspendLayout();
            this.pnToMail.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAttachFIle
            // 
            this.pnAttachFIle.Controls.Add(this.attachFilebtn);
            this.pnAttachFIle.Controls.Add(this.attachtxb);
            this.pnAttachFIle.Enabled = false;
            this.pnAttachFIle.Location = new System.Drawing.Point(12, 40);
            this.pnAttachFIle.Name = "pnAttachFIle";
            this.pnAttachFIle.Size = new System.Drawing.Size(558, 43);
            this.pnAttachFIle.TabIndex = 0;
            // 
            // attachFilebtn
            // 
            this.attachFilebtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachFilebtn.Location = new System.Drawing.Point(381, 4);
            this.attachFilebtn.Name = "attachFilebtn";
            this.attachFilebtn.Size = new System.Drawing.Size(166, 36);
            this.attachFilebtn.TabIndex = 1;
            this.attachFilebtn.Text = "Attach";
            this.attachFilebtn.UseVisualStyleBackColor = true;
            this.attachFilebtn.Click += new System.EventHandler(this.attachbtn_Click);
            // 
            // attachtxb
            // 
            this.attachtxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachtxb.Location = new System.Drawing.Point(17, 4);
            this.attachtxb.Name = "attachtxb";
            this.attachtxb.Size = new System.Drawing.Size(353, 27);
            this.attachtxb.TabIndex = 5;
            // 
            // pnToMail
            // 
            this.pnToMail.Controls.Add(this.attachListMailbtn);
            this.pnToMail.Controls.Add(this.label1);
            this.pnToMail.Controls.Add(this.totxb);
            this.pnToMail.Enabled = false;
            this.pnToMail.Location = new System.Drawing.Point(12, 122);
            this.pnToMail.Name = "pnToMail";
            this.pnToMail.Size = new System.Drawing.Size(902, 44);
            this.pnToMail.TabIndex = 2;
            // 
            // attachListMailbtn
            // 
            this.attachListMailbtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachListMailbtn.Location = new System.Drawing.Point(717, 6);
            this.attachListMailbtn.Name = "attachListMailbtn";
            this.attachListMailbtn.Size = new System.Drawing.Size(166, 36);
            this.attachListMailbtn.TabIndex = 6;
            this.attachListMailbtn.Text = "Attach";
            this.attachListMailbtn.UseVisualStyleBackColor = true;
            this.attachListMailbtn.Click += new System.EventHandler(this.attachListMailbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // totxb
            // 
            this.totxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totxb.Location = new System.Drawing.Point(138, 10);
            this.totxb.Name = "totxb";
            this.totxb.Size = new System.Drawing.Size(561, 27);
            this.totxb.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.subjecttxb);
            this.panel3.Location = new System.Drawing.Point(12, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 42);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // subjecttxb
            // 
            this.subjecttxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjecttxb.Location = new System.Drawing.Point(138, 7);
            this.subjecttxb.Name = "subjecttxb";
            this.subjecttxb.Size = new System.Drawing.Size(561, 27);
            this.subjecttxb.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbShowPass);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.passwordtxb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.usernametxb);
            this.panel4.Location = new System.Drawing.Point(12, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 114);
            this.panel4.TabIndex = 3;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(140, 88);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(121, 21);
            this.cbShowPass.TabIndex = 4;
            this.cbShowPass.Text = "Hiện mật khẩu";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // passwordtxb
            // 
            this.passwordtxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxb.Location = new System.Drawing.Point(138, 49);
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.Size = new System.Drawing.Size(561, 27);
            this.passwordtxb.TabIndex = 3;
            this.passwordtxb.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // usernametxb
            // 
            this.usernametxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxb.Location = new System.Drawing.Point(138, 11);
            this.usernametxb.Name = "usernametxb";
            this.usernametxb.Size = new System.Drawing.Size(561, 27);
            this.usernametxb.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbAttachedMessage);
            this.panel6.Controls.Add(this.btnAttachMessageMail);
            this.panel6.Controls.Add(this.messagetxb);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.sendbtn);
            this.panel6.Location = new System.Drawing.Point(12, 340);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(902, 195);
            this.panel6.TabIndex = 5;
            // 
            // btnAttachMessageMail
            // 
            this.btnAttachMessageMail.Enabled = false;
            this.btnAttachMessageMail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachMessageMail.Location = new System.Drawing.Point(545, 10);
            this.btnAttachMessageMail.Name = "btnAttachMessageMail";
            this.btnAttachMessageMail.Size = new System.Drawing.Size(166, 36);
            this.btnAttachMessageMail.TabIndex = 5;
            this.btnAttachMessageMail.Text = "Attach";
            this.btnAttachMessageMail.UseVisualStyleBackColor = true;
            // 
            // messagetxb
            // 
            this.messagetxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagetxb.Location = new System.Drawing.Point(17, 56);
            this.messagetxb.Multiline = true;
            this.messagetxb.Name = "messagetxb";
            this.messagetxb.Size = new System.Drawing.Size(880, 125);
            this.messagetxb.TabIndex = 4;
            this.messagetxb.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Messages";
            // 
            // sendbtn
            // 
            this.sendbtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.Location = new System.Drawing.Point(717, 10);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(166, 36);
            this.sendbtn.TabIndex = 0;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(748, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(576, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(576, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(338, 30);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbToMail
            // 
            this.cbToMail.AutoSize = true;
            this.cbToMail.Location = new System.Drawing.Point(150, 92);
            this.cbToMail.Name = "cbToMail";
            this.cbToMail.Size = new System.Drawing.Size(76, 21);
            this.cbToMail.TabIndex = 5;
            this.cbToMail.Text = "To Mail";
            this.cbToMail.UseVisualStyleBackColor = true;
            this.cbToMail.CheckedChanged += new System.EventHandler(this.cbToMail_CheckedChanged);
            // 
            // cbToListMail
            // 
            this.cbToListMail.AutoSize = true;
            this.cbToListMail.Location = new System.Drawing.Point(260, 92);
            this.cbToListMail.Name = "cbToListMail";
            this.cbToListMail.Size = new System.Drawing.Size(102, 21);
            this.cbToListMail.TabIndex = 7;
            this.cbToListMail.Text = "To List Mail";
            this.cbToListMail.UseVisualStyleBackColor = true;
            this.cbToListMail.CheckedChanged += new System.EventHandler(this.cbToListMail_CheckedChanged);
            // 
            // cbAttachedFile
            // 
            this.cbAttachedFile.AutoSize = true;
            this.cbAttachedFile.Location = new System.Drawing.Point(12, 7);
            this.cbAttachedFile.Name = "cbAttachedFile";
            this.cbAttachedFile.Size = new System.Drawing.Size(86, 21);
            this.cbAttachedFile.TabIndex = 8;
            this.cbAttachedFile.Text = "Attached";
            this.cbAttachedFile.UseVisualStyleBackColor = true;
            this.cbAttachedFile.CheckedChanged += new System.EventHandler(this.cbAttachedFile_CheckedChanged);
            // 
            // cbAttachedMessage
            // 
            this.cbAttachedMessage.AutoSize = true;
            this.cbAttachedMessage.Location = new System.Drawing.Point(444, 20);
            this.cbAttachedMessage.Name = "cbAttachedMessage";
            this.cbAttachedMessage.Size = new System.Drawing.Size(86, 21);
            this.cbAttachedMessage.TabIndex = 9;
            this.cbAttachedMessage.Text = "Attached";
            this.cbAttachedMessage.UseVisualStyleBackColor = true;
            this.cbAttachedMessage.CheckedChanged += new System.EventHandler(this.cbAttachedMessage_CheckedChanged);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 547);
            this.Controls.Add(this.cbToListMail);
            this.Controls.Add(this.cbAttachedFile);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbToMail);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnToMail);
            this.Controls.Add(this.pnAttachFIle);
            this.Name = "SendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi Mail";
            this.pnAttachFIle.ResumeLayout(false);
            this.pnAttachFIle.PerformLayout();
            this.pnToMail.ResumeLayout(false);
            this.pnToMail.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnAttachFIle;
        private System.Windows.Forms.Button attachFilebtn;
        private System.Windows.Forms.TextBox attachtxb;
        private System.Windows.Forms.Panel pnToMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totxb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjecttxb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernametxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox passwordtxb;
        private System.Windows.Forms.TextBox messagetxb;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button attachListMailbtn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.Button btnAttachMessageMail;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cbToListMail;
        private System.Windows.Forms.CheckBox cbToMail;
        private System.Windows.Forms.CheckBox cbAttachedFile;
        private System.Windows.Forms.CheckBox cbAttachedMessage;
    }
}

