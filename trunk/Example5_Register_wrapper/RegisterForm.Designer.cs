namespace Example5_Register_wrapper
{
  partial class RegisterForm
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
      this.buttonRegister = new System.Windows.Forms.Button();
      this.textBoxRegistrar = new System.Windows.Forms.TextBox();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.textBoxUsername = new System.Windows.Forms.TextBox();
      this.textBoxId = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxStatus = new System.Windows.Forms.TextBox();
      this.labelStatus = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxDomain = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // buttonRegister
      // 
      this.buttonRegister.Location = new System.Drawing.Point(96, 174);
      this.buttonRegister.Name = "buttonRegister";
      this.buttonRegister.Size = new System.Drawing.Size(104, 23);
      this.buttonRegister.TabIndex = 0;
      this.buttonRegister.Text = "Go register...";
      this.buttonRegister.UseVisualStyleBackColor = true;
      this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
      // 
      // textBoxRegistrar
      // 
      this.textBoxRegistrar.Location = new System.Drawing.Point(96, 134);
      this.textBoxRegistrar.Name = "textBoxRegistrar";
      this.textBoxRegistrar.Size = new System.Drawing.Size(165, 20);
      this.textBoxRegistrar.TabIndex = 5;
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(96, 82);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.PasswordChar = '*';
      this.textBoxPassword.Size = new System.Drawing.Size(139, 20);
      this.textBoxPassword.TabIndex = 3;
      // 
      // textBoxUsername
      // 
      this.textBoxUsername.Location = new System.Drawing.Point(96, 56);
      this.textBoxUsername.Name = "textBoxUsername";
      this.textBoxUsername.Size = new System.Drawing.Size(139, 20);
      this.textBoxUsername.TabIndex = 2;
      // 
      // textBoxId
      // 
      this.textBoxId.Location = new System.Drawing.Point(96, 30);
      this.textBoxId.Name = "textBoxId";
      this.textBoxId.Size = new System.Drawing.Size(139, 20);
      this.textBoxId.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 137);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Registrar";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 30);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(16, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Id";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Username";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 82);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Password";
      // 
      // textBoxStatus
      // 
      this.textBoxStatus.Location = new System.Drawing.Point(96, 232);
      this.textBoxStatus.Name = "textBoxStatus";
      this.textBoxStatus.ReadOnly = true;
      this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
      this.textBoxStatus.TabIndex = 6;
      // 
      // labelStatus
      // 
      this.labelStatus.AutoSize = true;
      this.labelStatus.Location = new System.Drawing.Point(18, 235);
      this.labelStatus.Name = "labelStatus";
      this.labelStatus.Size = new System.Drawing.Size(37, 13);
      this.labelStatus.TabIndex = 10;
      this.labelStatus.Text = "Status";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(18, 108);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(43, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Domain";
      // 
      // textBoxDomain
      // 
      this.textBoxDomain.Location = new System.Drawing.Point(96, 108);
      this.textBoxDomain.Name = "textBoxDomain";
      this.textBoxDomain.Size = new System.Drawing.Size(139, 20);
      this.textBoxDomain.TabIndex = 4;
      this.textBoxDomain.Text = "*";
      // 
      // RegisterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(280, 273);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBoxDomain);
      this.Controls.Add(this.labelStatus);
      this.Controls.Add(this.textBoxStatus);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxId);
      this.Controls.Add(this.textBoxUsername);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.textBoxRegistrar);
      this.Controls.Add(this.buttonRegister);
      this.Name = "RegisterForm";
      this.Text = "Example5_Register_wrapper";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonRegister;
    private System.Windows.Forms.TextBox textBoxRegistrar;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.TextBox textBoxId;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxStatus;
    private System.Windows.Forms.Label labelStatus;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxDomain;
  }
}

