namespace SipekMobile
{
    partial class SettingsForm
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
          this.mainMenu1 = new System.Windows.Forms.MainMenu();
          this.menuItem1 = new System.Windows.Forms.MenuItem();
          this.menuItem2 = new System.Windows.Forms.MenuItem();
          this.menuItem3 = new System.Windows.Forms.MenuItem();
          this.textBoxUserName = new System.Windows.Forms.TextBox();
          this.UserName = new System.Windows.Forms.Label();
          this.textBoxDomain = new System.Windows.Forms.TextBox();
          this.label1 = new System.Windows.Forms.Label();
          this.textBoxPW = new System.Windows.Forms.TextBox();
          this.label2 = new System.Windows.Forms.Label();
          this.statusBar1 = new System.Windows.Forms.StatusBar();
          this.buttonRegister = new System.Windows.Forms.Button();
          this.buttonExit = new System.Windows.Forms.Button();
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
          // 
          // menuItem2
          // 
          this.menuItem2.Text = "Register";
          this.menuItem2.Click += new System.EventHandler(this.registerButton_Click);
          // 
          // menuItem3
          // 
          this.menuItem3.Text = "Exit";
          this.menuItem3.Click += new System.EventHandler(this.exitButton_Click);
          // 
          // textBoxUserName
          // 
          this.textBoxUserName.Location = new System.Drawing.Point(83, 97);
          this.textBoxUserName.Name = "textBoxUserName";
          this.textBoxUserName.Size = new System.Drawing.Size(105, 21);
          this.textBoxUserName.TabIndex = 1;
          // 
          // UserName
          // 
          this.UserName.Location = new System.Drawing.Point(3, 97);
          this.UserName.Name = "UserName";
          this.UserName.Size = new System.Drawing.Size(61, 20);
          this.UserName.Text = "Username";
          // 
          // textBoxDomain
          // 
          this.textBoxDomain.Location = new System.Drawing.Point(83, 51);
          this.textBoxDomain.Name = "textBoxDomain";
          this.textBoxDomain.Size = new System.Drawing.Size(150, 21);
          this.textBoxDomain.TabIndex = 0;
          // 
          // label1
          // 
          this.label1.Location = new System.Drawing.Point(3, 51);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(100, 20);
          this.label1.Text = "SIP Server";
          // 
          // textBoxPW
          // 
          this.textBoxPW.Location = new System.Drawing.Point(83, 144);
          this.textBoxPW.Name = "textBoxPW";
          this.textBoxPW.Size = new System.Drawing.Size(105, 21);
          this.textBoxPW.TabIndex = 2;
          // 
          // label2
          // 
          this.label2.Location = new System.Drawing.Point(3, 145);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(100, 20);
          this.label2.Text = "Password";
          // 
          // statusBar1
          // 
          this.statusBar1.Location = new System.Drawing.Point(0, 241);
          this.statusBar1.Name = "statusBar1";
          this.statusBar1.Size = new System.Drawing.Size(240, 22);
          // 
          // buttonRegister
          // 
          this.buttonRegister.Location = new System.Drawing.Point(161, 202);
          this.buttonRegister.Name = "buttonRegister";
          this.buttonRegister.Size = new System.Drawing.Size(72, 20);
          this.buttonRegister.TabIndex = 3;
          this.buttonRegister.Text = "Register";
          this.buttonRegister.Click += new System.EventHandler(this.registerButton_Click);
          // 
          // buttonExit
          // 
          this.buttonExit.Location = new System.Drawing.Point(4, 202);
          this.buttonExit.Name = "buttonExit";
          this.buttonExit.Size = new System.Drawing.Size(72, 20);
          this.buttonExit.TabIndex = 10;
          this.buttonExit.Text = "Exit";
          this.buttonExit.Click += new System.EventHandler(this.exitButton_Click);
          // 
          // SettingsForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
          this.AutoScroll = true;
          this.ClientSize = new System.Drawing.Size(240, 263);
          this.Controls.Add(this.buttonExit);
          this.Controls.Add(this.buttonRegister);
          this.Controls.Add(this.statusBar1);
          this.Controls.Add(this.textBoxPW);
          this.Controls.Add(this.textBoxDomain);
          this.Controls.Add(this.textBoxUserName);
          this.Controls.Add(this.UserName);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.label2);
          this.Menu = this.mainMenu1;
          this.Name = "SettingsForm";
          this.Text = "Sipek Mobile";
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPW;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.MenuItem menuItem1;
      private System.Windows.Forms.MenuItem menuItem2;
      private System.Windows.Forms.MenuItem menuItem3;
      private System.Windows.Forms.StatusBar statusBar1;
      private System.Windows.Forms.Button buttonRegister;
      private System.Windows.Forms.Button buttonExit;
    }
}

