namespace SipekMobile
{
    partial class PhoneForm
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
          this.textBoxNumber = new System.Windows.Forms.TextBox();
          this.label1 = new System.Windows.Forms.Label();
          this.buttonCall = new System.Windows.Forms.Button();
          this.statusBar1 = new System.Windows.Forms.StatusBar();
          this.buttonRelease = new System.Windows.Forms.Button();
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
          this.menuItem2.Text = "Call";
          this.menuItem2.Click += new System.EventHandler(this.callButton_Click);
          // 
          // menuItem3
          // 
          this.menuItem3.Text = "Exit";
          this.menuItem3.Click += new System.EventHandler(this.exitButton_Click);
          // 
          // textBoxNumber
          // 
          this.textBoxNumber.Location = new System.Drawing.Point(67, 42);
          this.textBoxNumber.Name = "textBoxNumber";
          this.textBoxNumber.Size = new System.Drawing.Size(170, 21);
          this.textBoxNumber.TabIndex = 2;
          // 
          // label1
          // 
          this.label1.Location = new System.Drawing.Point(3, 43);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(100, 20);
          this.label1.Text = "Number";
          // 
          // buttonCall
          // 
          this.buttonCall.Location = new System.Drawing.Point(165, 82);
          this.buttonCall.Name = "buttonCall";
          this.buttonCall.Size = new System.Drawing.Size(72, 20);
          this.buttonCall.TabIndex = 31;
          this.buttonCall.Text = "Call";
          this.buttonCall.Click += new System.EventHandler(this.callButton_Click);
          // 
          // statusBar1
          // 
          this.statusBar1.Location = new System.Drawing.Point(0, 246);
          this.statusBar1.Name = "statusBar1";
          this.statusBar1.Size = new System.Drawing.Size(240, 22);
          this.statusBar1.Text = "statusBar1";
          // 
          // buttonRelease
          // 
          this.buttonRelease.Location = new System.Drawing.Point(67, 82);
          this.buttonRelease.Name = "buttonRelease";
          this.buttonRelease.Size = new System.Drawing.Size(72, 20);
          this.buttonRelease.TabIndex = 34;
          this.buttonRelease.Text = "Release";
          this.buttonRelease.Click += new System.EventHandler(this.releaseButton_Click);
          // 
          // buttonExit
          // 
          this.buttonExit.Location = new System.Drawing.Point(164, 220);
          this.buttonExit.Name = "buttonExit";
          this.buttonExit.Size = new System.Drawing.Size(72, 20);
          this.buttonExit.TabIndex = 37;
          this.buttonExit.Text = "Exit";
          this.buttonExit.Click += new System.EventHandler(this.exitButton_Click);
          // 
          // PhoneForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
          this.AutoScroll = true;
          this.ClientSize = new System.Drawing.Size(240, 268);
          this.Controls.Add(this.buttonExit);
          this.Controls.Add(this.buttonRelease);
          this.Controls.Add(this.statusBar1);
          this.Controls.Add(this.buttonCall);
          this.Controls.Add(this.textBoxNumber);
          this.Controls.Add(this.label1);
          this.Menu = this.mainMenu1;
          this.Name = "PhoneForm";
          this.Text = "Sipek Mobile";
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.MenuItem menuItem1;
      private System.Windows.Forms.MenuItem menuItem2;
      private System.Windows.Forms.MenuItem menuItem3;
      private System.Windows.Forms.Button buttonCall;
      private System.Windows.Forms.StatusBar statusBar1;
      private System.Windows.Forms.Button buttonRelease;
      private System.Windows.Forms.Button buttonExit;
    }
}