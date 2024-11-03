namespace HotelReceptionistsSystem
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.pictureBoxHidden = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 698);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 112);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2023. All Rights Reserved. C# Kelompok 5 ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.pictureBoxShow);
            this.groupBox1.Controls.Add(this.pictureBoxHidden);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(99, 182);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(561, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Staff Login";
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxShow.Image = global::HotelReceptionistsSystem.Properties.Resources.showpass;
            this.pictureBoxShow.Location = new System.Drawing.Point(434, 203);
            this.pictureBoxShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(30, 26);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 7;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
            this.pictureBoxShow.MouseHover += new System.EventHandler(this.pictureBoxShow_MouseHover);
            // 
            // pictureBoxHidden
            // 
            this.pictureBoxHidden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxHidden.Image = global::HotelReceptionistsSystem.Properties.Resources.hiddenpass;
            this.pictureBoxHidden.Location = new System.Drawing.Point(434, 203);
            this.pictureBoxHidden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxHidden.Name = "pictureBoxHidden";
            this.pictureBoxHidden.Size = new System.Drawing.Size(30, 26);
            this.pictureBoxHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHidden.TabIndex = 6;
            this.pictureBoxHidden.TabStop = false;
            this.pictureBoxHidden.Click += new System.EventHandler(this.pictureBoxHidden_Click);
            this.pictureBoxHidden.MouseHover += new System.EventHandler(this.pictureBoxHidden_MouseHover);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(90, 203);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(374, 29);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(90, 319);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(375, 58);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(90, 117);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(374, 29);
            this.textBoxUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(801, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 502);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(997, 623);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heaven\'s Door Hotel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelReceptionistsSystem.Properties.Resources.receptionist;
            this.pictureBox2.Location = new System.Drawing.Point(944, 226);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(441, 395);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Image = global::HotelReceptionistsSystem.Properties.Resources.minimize;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1451, 0);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(39, 40);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 1;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            this.pictureBoxMinimize.MouseHover += new System.EventHandler(this.pictureBoxMinimize_MouseHover);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::HotelReceptionistsSystem.Properties.Resources.close_window;
            this.pictureBoxClose.Location = new System.Drawing.Point(1497, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(39, 40);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1537, 810);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.pictureBoxClose);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxHidden;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxShow;
    }
}

