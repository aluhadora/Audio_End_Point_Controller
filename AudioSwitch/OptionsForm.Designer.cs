namespace AudioSwitcherOptions
{
  partial class OptionsForm
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
      this.optionsTextBox = new System.Windows.Forms.TextBox();
      this.saveButton = new System.Windows.Forms.Button();
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Audio device ID:";
      // 
      // optionsTextBox
      // 
      this.optionsTextBox.Location = new System.Drawing.Point(105, 10);
      this.optionsTextBox.MaxLength = 9;
      this.optionsTextBox.Name = "optionsTextBox";
      this.optionsTextBox.Size = new System.Drawing.Size(63, 20);
      this.optionsTextBox.TabIndex = 9;
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(12, 36);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(75, 23);
      this.saveButton.TabIndex = 2;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // textBox1
      // 
      this.idTextBox.Location = new System.Drawing.Point(174, 10);
      this.idTextBox.MaxLength = 1;
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.Size = new System.Drawing.Size(20, 20);
      this.idTextBox.TabIndex = 10;
      // 
      // OptionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(199, 67);
      this.Controls.Add(this.idTextBox);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.optionsTextBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "OptionsForm";
      this.Text = "Options";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox optionsTextBox;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.TextBox idTextBox;
  }
}

