
namespace PresentationLayer
{
    partial class FirstNameForm
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
            this.FName = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.EmptyWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(24, 65);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(67, 15);
            this.FName.TabIndex = 0;
            this.FName.Text = "First Name:";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(24, 129);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(66, 15);
            this.LName.TabIndex = 1;
            this.LName.Text = "Last Name:";
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(97, 57);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(100, 23);
            this.FNameBox.TabIndex = 2;
            // 
            // LNameBox
            // 
            this.LNameBox.Enabled = false;
            this.LNameBox.Location = new System.Drawing.Point(97, 121);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(100, 23);
            this.LNameBox.TabIndex = 3;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(12, 192);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(133, 23);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update First Name";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(175, 192);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EmptyWarning
            // 
            this.EmptyWarning.AutoSize = true;
            this.EmptyWarning.ForeColor = System.Drawing.Color.Red;
            this.EmptyWarning.Location = new System.Drawing.Point(12, 244);
            this.EmptyWarning.Name = "EmptyWarning";
            this.EmptyWarning.Size = new System.Drawing.Size(256, 15);
            this.EmptyWarning.TabIndex = 6;
            this.EmptyWarning.Text = "*Please Enter Something into First Name Feild!*";
            this.EmptyWarning.Visible = false;
            // 
            // FirstNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 290);
            this.Controls.Add(this.EmptyWarning);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FName);
            this.Name = "FirstNameForm";
            this.Text = "FirstNameForm";
            this.Load += new System.EventHandler(this.FirstNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label EmptyWarning;
    }
}