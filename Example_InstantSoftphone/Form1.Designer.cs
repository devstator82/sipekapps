namespace InstantSoftphone
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
      this.textBoxDial = new System.Windows.Forms.TextBox();
      this.buttonMakeCall = new System.Windows.Forms.Button();
      this.buttonReleaseCall = new System.Windows.Forms.Button();
      this.textBoxRegState = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxCallState = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBoxDial
      // 
      this.textBoxDial.Location = new System.Drawing.Point(16, 42);
      this.textBoxDial.Name = "textBoxDial";
      this.textBoxDial.Size = new System.Drawing.Size(146, 20);
      this.textBoxDial.TabIndex = 0;
      // 
      // buttonMakeCall
      // 
      this.buttonMakeCall.Location = new System.Drawing.Point(179, 39);
      this.buttonMakeCall.Name = "buttonMakeCall";
      this.buttonMakeCall.Size = new System.Drawing.Size(75, 23);
      this.buttonMakeCall.TabIndex = 1;
      this.buttonMakeCall.Text = "Make Call";
      this.buttonMakeCall.UseVisualStyleBackColor = true;
      this.buttonMakeCall.Click += new System.EventHandler(this.buttonMakeCall_Click);
      // 
      // buttonReleaseCall
      // 
      this.buttonReleaseCall.Location = new System.Drawing.Point(279, 39);
      this.buttonReleaseCall.Name = "buttonReleaseCall";
      this.buttonReleaseCall.Size = new System.Drawing.Size(75, 23);
      this.buttonReleaseCall.TabIndex = 2;
      this.buttonReleaseCall.Text = "Realease";
      this.buttonReleaseCall.UseVisualStyleBackColor = true;
      this.buttonReleaseCall.Click += new System.EventHandler(this.buttonReleaseCall_Click);
      // 
      // textBoxRegState
      // 
      this.textBoxRegState.Location = new System.Drawing.Point(232, 86);
      this.textBoxRegState.Name = "textBoxRegState";
      this.textBoxRegState.ReadOnly = true;
      this.textBoxRegState.Size = new System.Drawing.Size(122, 20);
      this.textBoxRegState.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(130, 89);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Registration Status";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(169, 123);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Call Status";
      // 
      // textBoxCallState
      // 
      this.textBoxCallState.Location = new System.Drawing.Point(232, 120);
      this.textBoxCallState.Name = "textBoxCallState";
      this.textBoxCallState.ReadOnly = true;
      this.textBoxCallState.Size = new System.Drawing.Size(122, 20);
      this.textBoxCallState.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(366, 145);
      this.Controls.Add(this.textBoxCallState);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxRegState);
      this.Controls.Add(this.buttonReleaseCall);
      this.Controls.Add(this.buttonMakeCall);
      this.Controls.Add(this.textBoxDial);
      this.Name = "Form1";
      this.Text = "Sipek Instant Softphone";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxDial;
    private System.Windows.Forms.Button buttonMakeCall;
    private System.Windows.Forms.Button buttonReleaseCall;
    private System.Windows.Forms.TextBox textBoxRegState;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxCallState;
  }
}

