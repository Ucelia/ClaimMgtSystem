namespace GQApp
{
    partial class AttendEvent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eventCombo = new System.Windows.Forms.ComboBox();
            this.statusBtn = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.requestBtn = new System.Windows.Forms.Button();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(77, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 77);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Attending Event";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventCombo
            // 
            this.eventCombo.FormattingEnabled = true;
            this.eventCombo.Items.AddRange(new object[] {
            "YOUTH CONNECT",
            "AFRILET",
            "CYBERTECH"});
            this.eventCombo.Location = new System.Drawing.Point(77, 423);
            this.eventCombo.Name = "eventCombo";
            this.eventCombo.Size = new System.Drawing.Size(353, 28);
            this.eventCombo.TabIndex = 25;
            // 
            // statusBtn
            // 
            this.statusBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.statusBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.statusBtn.ForeColor = System.Drawing.Color.White;
            this.statusBtn.Location = new System.Drawing.Point(346, 502);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(118, 51);
            this.statusBtn.TabIndex = 24;
            this.statusBtn.Text = "Status";
            this.statusBtn.UseVisualStyleBackColor = false;
            this.statusBtn.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(77, 304);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(676, 46);
            this.emailBox.TabIndex = 23;
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(77, 207);
            this.fullNameBox.Multiline = true;
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(676, 46);
            this.fullNameBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Event";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Full Name";
            // 
            // requestBtn
            // 
            this.requestBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.requestBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.requestBtn.ForeColor = System.Drawing.Color.White;
            this.requestBtn.Location = new System.Drawing.Point(626, 388);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(127, 63);
            this.requestBtn.TabIndex = 26;
            this.requestBtn.Text = "Submit Request";
            this.requestBtn.UseVisualStyleBackColor = false;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.LinkColor = System.Drawing.Color.RoyalBlue;
            this.logoutLink.Location = new System.Drawing.Point(675, 534);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(67, 19);
            this.logoutLink.TabIndex = 40;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // AttendEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 608);
            this.Controls.Add(this.logoutLink);
            this.Controls.Add(this.requestBtn);
            this.Controls.Add(this.eventCombo);
            this.Controls.Add(this.statusBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AttendEvent";
            this.Text = "AttendEvent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventCombo;
        private System.Windows.Forms.Button statusBtn;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button requestBtn;
        private System.Windows.Forms.LinkLabel logoutLink;
    }
}