namespace Example5_Register_wrapper
{
  partial class MessagingForm
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
      this.textBoxSender = new System.Windows.Forms.TextBox();
      this.textBoxReceiver = new System.Windows.Forms.TextBox();
      this.buttonBuddy1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.buttonClear = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxSender
      // 
      this.textBoxSender.Location = new System.Drawing.Point(12, 45);
      this.textBoxSender.Multiline = true;
      this.textBoxSender.Name = "textBoxSender";
      this.textBoxSender.Size = new System.Drawing.Size(201, 112);
      this.textBoxSender.TabIndex = 0;
      // 
      // textBoxReceiver
      // 
      this.textBoxReceiver.Location = new System.Drawing.Point(323, 45);
      this.textBoxReceiver.Multiline = true;
      this.textBoxReceiver.Name = "textBoxReceiver";
      this.textBoxReceiver.ReadOnly = true;
      this.textBoxReceiver.Size = new System.Drawing.Size(201, 112);
      this.textBoxReceiver.TabIndex = 1;
      // 
      // buttonBuddy1
      // 
      this.buttonBuddy1.Location = new System.Drawing.Point(117, 177);
      this.buttonBuddy1.Name = "buttonBuddy1";
      this.buttonBuddy1.Size = new System.Drawing.Size(96, 23);
      this.buttonBuddy1.TabIndex = 3;
      this.buttonBuddy1.Text = "Send message";
      this.buttonBuddy1.UseVisualStyleBackColor = true;
      this.buttonBuddy1.Click += new System.EventHandler(this.buttonBuddy1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(81, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Enter Message:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(320, 25);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Echo:";
      // 
      // buttonClear
      // 
      this.buttonClear.Location = new System.Drawing.Point(12, 177);
      this.buttonClear.Name = "buttonClear";
      this.buttonClear.Size = new System.Drawing.Size(75, 23);
      this.buttonClear.TabIndex = 6;
      this.buttonClear.Text = "Clear";
      this.buttonClear.UseVisualStyleBackColor = true;
      this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
      // 
      // MessagingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(536, 224);
      this.Controls.Add(this.buttonClear);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonBuddy1);
      this.Controls.Add(this.textBoxReceiver);
      this.Controls.Add(this.textBoxSender);
      this.Name = "MessagingForm";
      this.Text = "Example6_Messenger_wrapper";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxSender;
    private System.Windows.Forms.TextBox textBoxReceiver;
    private System.Windows.Forms.Button buttonBuddy1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button buttonClear;

  }
}

