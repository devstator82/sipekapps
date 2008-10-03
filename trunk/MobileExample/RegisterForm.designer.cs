namespace vmhtStackProject
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
          this.mainMenu1 = new System.Windows.Forms.MainMenu();
          this.menuItem1 = new System.Windows.Forms.MenuItem();
          this.menuItem2 = new System.Windows.Forms.MenuItem();
          this.menuItem3 = new System.Windows.Forms.MenuItem();
          this.pictureBox1 = new System.Windows.Forms.PictureBox();
          this.textBoxUserName = new System.Windows.Forms.TextBox();
          this.UserName = new System.Windows.Forms.Label();
          this.textBoxDomain = new System.Windows.Forms.TextBox();
          this.label1 = new System.Windows.Forms.Label();
          this.textBoxPW = new System.Windows.Forms.TextBox();
          this.label2 = new System.Windows.Forms.Label();
          this.textBoxStatus = new System.Windows.Forms.TextBox();
          this.label3 = new System.Windows.Forms.Label();
          this.registerButton = new System.Windows.Forms.PictureBox();
          this.exitButton = new System.Windows.Forms.PictureBox();
          this.SuspendLayout();
          // 
          // mainMenu1
          // 
          this.mainMenu1.MenuItems.Add(this.menuItem1);
          // 
          // menuItem1
          // 
          this.menuItem1.MenuItems.Add(this.menuItem2);
          this.menuItem1.MenuItems.Add(this.menuItem3);
          this.menuItem1.Text = "Menu";
          this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
          // 
          // menuItem2
          // 
          this.menuItem2.Text = "Register";
          this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
          // 
          // menuItem3
          // 
          this.menuItem3.Text = "Exit";
          this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
          // 
          // pictureBox1
          // 
          this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
          this.pictureBox1.Location = new System.Drawing.Point(0, 0);
          this.pictureBox1.Name = "pictureBox1";
          this.pictureBox1.Size = new System.Drawing.Size(240, 263);
          // 
          // textBoxUserName
          // 
          this.textBoxUserName.Location = new System.Drawing.Point(71, 115);
          this.textBoxUserName.Name = "textBoxUserName";
          this.textBoxUserName.Size = new System.Drawing.Size(122, 21);
          this.textBoxUserName.TabIndex = 1;
          this.textBoxUserName.Text = "4444";
          // 
          // UserName
          // 
          this.UserName.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
          this.UserName.ForeColor = System.Drawing.Color.Orange;
          this.UserName.Location = new System.Drawing.Point(71, 98);
          this.UserName.Name = "UserName";
          this.UserName.Size = new System.Drawing.Size(100, 20);
          this.UserName.Text = "User Name";
          // 
          // textBoxDomain
          // 
          this.textBoxDomain.Location = new System.Drawing.Point(71, 62);
          this.textBoxDomain.Name = "textBoxDomain";
          this.textBoxDomain.Size = new System.Drawing.Size(122, 21);
          this.textBoxDomain.TabIndex = 3;
          this.textBoxDomain.Text = "voip1.callpal.net";
          // 
          // label1
          // 
          this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
          this.label1.ForeColor = System.Drawing.Color.Orange;
          this.label1.Location = new System.Drawing.Point(72, 46);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(100, 20);
          this.label1.Text = "Domain";
          // 
          // textBoxPW
          // 
          this.textBoxPW.Location = new System.Drawing.Point(71, 168);
          this.textBoxPW.Name = "textBoxPW";
          this.textBoxPW.Size = new System.Drawing.Size(121, 21);
          this.textBoxPW.TabIndex = 6;
          this.textBoxPW.Text = "4444";
          // 
          // label2
          // 
          this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
          this.label2.ForeColor = System.Drawing.Color.Orange;
          this.label2.Location = new System.Drawing.Point(71, 150);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(100, 20);
          this.label2.Text = "PassWord";
          // 
          // textBoxStatus
          // 
          this.textBoxStatus.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
          this.textBoxStatus.Location = new System.Drawing.Point(161, 230);
          this.textBoxStatus.Name = "textBoxStatus";
          this.textBoxStatus.Size = new System.Drawing.Size(72, 19);
          this.textBoxStatus.TabIndex = 10;
          // 
          // label3
          // 
          this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
          this.label3.ForeColor = System.Drawing.Color.Orange;
          this.label3.Location = new System.Drawing.Point(162, 214);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(59, 20);
          this.label3.Text = "Status";
          // 
          // registerButton
          // 
          this.registerButton.Image = ((System.Drawing.Image)(resources.GetObject("registerButton.Image")));
          this.registerButton.Location = new System.Drawing.Point(91, 214);
          this.registerButton.Name = "registerButton";
          this.registerButton.Size = new System.Drawing.Size(64, 19);
          this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
          // 
          // exitButton
          // 
          this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
          this.exitButton.Location = new System.Drawing.Point(3, 213);
          this.exitButton.Name = "exitButton";
          this.exitButton.Size = new System.Drawing.Size(58, 20);
          this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
          // 
          // RegisterForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
          this.AutoScroll = true;
          this.ClientSize = new System.Drawing.Size(240, 263);
          this.Controls.Add(this.exitButton);
          this.Controls.Add(this.registerButton);
          this.Controls.Add(this.textBoxStatus);
          this.Controls.Add(this.textBoxPW);
          this.Controls.Add(this.textBoxDomain);
          this.Controls.Add(this.textBoxUserName);
          this.Controls.Add(this.UserName);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.pictureBox1);
          this.Menu = this.mainMenu1;
          this.Name = "RegisterForm";
          this.Text = "Form1";
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox registerButton;
        private System.Windows.Forms.PictureBox exitButton;
      private System.Windows.Forms.MenuItem menuItem1;
      private System.Windows.Forms.MenuItem menuItem2;
      private System.Windows.Forms.MenuItem menuItem3;
    }
}

