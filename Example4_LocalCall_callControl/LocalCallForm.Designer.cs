namespace Example4_LocalCall_callControl
{
  partial class LocalCallForm
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxOutCallState = new System.Windows.Forms.TextBox();
      this.buttonOutRelease = new System.Windows.Forms.Button();
      this.buttonOutCall = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonIncRelease = new System.Windows.Forms.Button();
      this.buttonIncAnswer = new System.Windows.Forms.Button();
      this.textBoxIncCallState = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.textBoxOutCallState);
      this.groupBox1.Controls.Add(this.buttonOutRelease);
      this.groupBox1.Controls.Add(this.buttonOutCall);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(181, 324);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Outgoing";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(43, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 14;
      this.label2.Text = "Call Status";
      // 
      // textBoxOutCallState
      // 
      this.textBoxOutCallState.Location = new System.Drawing.Point(43, 97);
      this.textBoxOutCallState.Name = "textBoxOutCallState";
      this.textBoxOutCallState.Size = new System.Drawing.Size(100, 20);
      this.textBoxOutCallState.TabIndex = 13;
      // 
      // buttonOutRelease
      // 
      this.buttonOutRelease.Location = new System.Drawing.Point(46, 148);
      this.buttonOutRelease.Name = "buttonOutRelease";
      this.buttonOutRelease.Size = new System.Drawing.Size(75, 23);
      this.buttonOutRelease.TabIndex = 12;
      this.buttonOutRelease.Text = "Release";
      this.buttonOutRelease.UseVisualStyleBackColor = true;
      this.buttonOutRelease.Click += new System.EventHandler(this.buttonOutRelease_Click);
      // 
      // buttonOutCall
      // 
      this.buttonOutCall.Location = new System.Drawing.Point(27, 34);
      this.buttonOutCall.Name = "buttonOutCall";
      this.buttonOutCall.Size = new System.Drawing.Size(116, 23);
      this.buttonOutCall.TabIndex = 10;
      this.buttonOutCall.Text = "Call the rigth side";
      this.buttonOutCall.UseVisualStyleBackColor = true;
      this.buttonOutCall.Click += new System.EventHandler(this.buttonOutCall_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.buttonIncRelease);
      this.groupBox2.Controls.Add(this.buttonIncAnswer);
      this.groupBox2.Controls.Add(this.textBoxIncCallState);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
      this.groupBox2.Location = new System.Drawing.Point(367, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(179, 324);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Incoming";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(40, 78);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Call Status";
      // 
      // buttonIncRelease
      // 
      this.buttonIncRelease.Location = new System.Drawing.Point(92, 148);
      this.buttonIncRelease.Name = "buttonIncRelease";
      this.buttonIncRelease.Size = new System.Drawing.Size(75, 23);
      this.buttonIncRelease.TabIndex = 2;
      this.buttonIncRelease.Text = "Release";
      this.buttonIncRelease.UseVisualStyleBackColor = true;
      this.buttonIncRelease.Click += new System.EventHandler(this.buttonIncRelease_Click);
      // 
      // buttonIncAnswer
      // 
      this.buttonIncAnswer.Location = new System.Drawing.Point(11, 148);
      this.buttonIncAnswer.Name = "buttonIncAnswer";
      this.buttonIncAnswer.Size = new System.Drawing.Size(75, 23);
      this.buttonIncAnswer.TabIndex = 1;
      this.buttonIncAnswer.Text = "Answer";
      this.buttonIncAnswer.UseVisualStyleBackColor = true;
      this.buttonIncAnswer.Click += new System.EventHandler(this.buttonIncAnswer_Click);
      // 
      // textBoxIncCallState
      // 
      this.textBoxIncCallState.Location = new System.Drawing.Point(40, 97);
      this.textBoxIncCallState.Name = "textBoxIncCallState";
      this.textBoxIncCallState.Size = new System.Drawing.Size(100, 20);
      this.textBoxIncCallState.TabIndex = 0;
      // 
      // LocalCallForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(546, 324);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "LocalCallForm";
      this.Text = "Local Call Example";
      this.Load += new System.EventHandler(this.LocalCallForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button buttonOutRelease;
    private System.Windows.Forms.Button buttonOutCall;
    private System.Windows.Forms.Button buttonIncRelease;
    private System.Windows.Forms.Button buttonIncAnswer;
    private System.Windows.Forms.TextBox textBoxIncCallState;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxOutCallState;
    private System.Windows.Forms.Label label1;
  }
}

