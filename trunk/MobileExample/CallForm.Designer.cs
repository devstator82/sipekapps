namespace vmhtStackProject
{
    partial class CallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCallState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumberCallLost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.callButton = new System.Windows.Forms.PictureBox();
            this.answerButton = new System.Windows.Forms.PictureBox();
            this.releaseButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 268);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(121, 42);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(100, 21);
            this.textBoxExtension.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(120, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Extension";
            // 
            // textBoxCallState
            // 
            this.textBoxCallState.Location = new System.Drawing.Point(17, 195);
            this.textBoxCallState.Name = "textBoxCallState";
            this.textBoxCallState.Size = new System.Drawing.Size(204, 21);
            this.textBoxCallState.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Call State";
            // 
            // textBoxNumberCallLost
            // 
            this.textBoxNumberCallLost.Location = new System.Drawing.Point(17, 139);
            this.textBoxNumberCallLost.Name = "textBoxNumberCallLost";
            this.textBoxNumberCallLost.Size = new System.Drawing.Size(55, 21);
            this.textBoxNumberCallLost.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.Text = "Call Lost";
            // 
            // callButton
            // 
            this.callButton.Image = ((System.Drawing.Image)(resources.GetObject("callButton.Image")));
            this.callButton.Location = new System.Drawing.Point(163, 74);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(58, 20);
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.Image = ((System.Drawing.Image)(resources.GetObject("answerButton.Image")));
            this.answerButton.Location = new System.Drawing.Point(58, 74);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(58, 20);
            this.answerButton.Visible = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // releaseButton
            // 
            this.releaseButton.Image = ((System.Drawing.Image)(resources.GetObject("releaseButton.Image")));
            this.releaseButton.Location = new System.Drawing.Point(56, 228);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(60, 20);
            this.releaseButton.Visible = false;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(161, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 20);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 139);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 21);
            this.textBox1.TabIndex = 24;
            // 
            // pin
            // 
            this.pin.Location = new System.Drawing.Point(194, 140);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(40, 20);
            this.pin.TabIndex = 25;
            this.pin.Text = "Ok";
            this.pin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(140, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.Text = "Pin";
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.releaseButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.textBoxNumberCallLost);
            this.Controls.Add(this.textBoxCallState);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "CallForm";
            this.Text = "CallForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCallState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumberCallLost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox callButton;
        private System.Windows.Forms.PictureBox answerButton;
        private System.Windows.Forms.PictureBox releaseButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pin;
        private System.Windows.Forms.Label label4;
    }
}