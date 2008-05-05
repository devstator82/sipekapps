namespace Example7_Presence_wrapper
{
  partial class PresenceForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBoxPresence = new System.Windows.Forms.ComboBox();
      this.textBoxStatus = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Set status";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(225, 25);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Check status";
      // 
      // comboBoxPresence
      // 
      this.comboBoxPresence.FormattingEnabled = true;
      this.comboBoxPresence.Location = new System.Drawing.Point(15, 52);
      this.comboBoxPresence.Name = "comboBoxPresence";
      this.comboBoxPresence.Size = new System.Drawing.Size(121, 21);
      this.comboBoxPresence.TabIndex = 6;
      this.comboBoxPresence.SelectedIndexChanged += new System.EventHandler(this.comboBoxPresence_SelectedIndexChanged);
      // 
      // textBoxStatus
      // 
      this.textBoxStatus.Location = new System.Drawing.Point(228, 52);
      this.textBoxStatus.Name = "textBoxStatus";
      this.textBoxStatus.ReadOnly = true;
      this.textBoxStatus.Size = new System.Drawing.Size(125, 20);
      this.textBoxStatus.TabIndex = 7;
      // 
      // PresenceForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(391, 187);
      this.Controls.Add(this.textBoxStatus);
      this.Controls.Add(this.comboBoxPresence);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "PresenceForm";
      this.Text = "Example7_Presence_wrapper";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBoxPresence;
    private System.Windows.Forms.TextBox textBoxStatus;

  }
}

