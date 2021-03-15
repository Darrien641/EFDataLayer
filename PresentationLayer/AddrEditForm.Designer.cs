
namespace PresentationLayer
{
    partial class AddrEditForm
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
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.ZipBox = new System.Windows.Forms.TextBox();
            this.AddrUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Required = new System.Windows.Forms.Label();
            this.StateReq = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(74, 83);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(100, 23);
            this.StreetBox.TabIndex = 1;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(74, 140);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(100, 23);
            this.CityBox.TabIndex = 2;
            // 
            // StateBox
            // 
            this.StateBox.Location = new System.Drawing.Point(74, 196);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(100, 23);
            this.StateBox.TabIndex = 3;
            this.StateBox.TextChanged += new System.EventHandler(this.StateBox_TextChanged);
            // 
            // ZipBox
            // 
            this.ZipBox.Location = new System.Drawing.Point(74, 254);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(100, 23);
            this.ZipBox.TabIndex = 4;
            // 
            // AddrUpdate
            // 
            this.AddrUpdate.Location = new System.Drawing.Point(35, 302);
            this.AddrUpdate.Name = "AddrUpdate";
            this.AddrUpdate.Size = new System.Drawing.Size(139, 28);
            this.AddrUpdate.TabIndex = 5;
            this.AddrUpdate.Text = "Update Address";
            this.AddrUpdate.UseVisualStyleBackColor = true;
            this.AddrUpdate.Click += new System.EventHandler(this.AddrUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Street:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zip:";
            // 
            // Required
            // 
            this.Required.AutoSize = true;
            this.Required.ForeColor = System.Drawing.Color.Red;
            this.Required.Location = new System.Drawing.Point(11, 348);
            this.Required.Name = "Required";
            this.Required.Size = new System.Drawing.Size(261, 15);
            this.Required.TabIndex = 10;
            this.Required.Text = "*Please Make Sure All Feilds Have Been Filled In*";
            this.Required.Visible = false;
            // 
            // StateReq
            // 
            this.StateReq.AutoSize = true;
            this.StateReq.ForeColor = System.Drawing.Color.Red;
            this.StateReq.Location = new System.Drawing.Point(17, 372);
            this.StateReq.Name = "StateReq";
            this.StateReq.Size = new System.Drawing.Size(180, 15);
            this.StateReq.TabIndex = 11;
            this.StateReq.Text = "*Please Use State Abbreviations!*";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(229, 306);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 406);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.StateReq);
            this.Controls.Add(this.Required);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddrUpdate);
            this.Controls.Add(this.ZipBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.label1);
            this.Name = "AddrEditForm";
            this.Text = "AddrEditFormcs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddrEditForm_FormClosed);
            this.Load += new System.EventHandler(this.AddrEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox ZipBox;
        private System.Windows.Forms.Button AddrUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Required;
        private System.Windows.Forms.Label StateReq;
        private System.Windows.Forms.Button Cancel;
    }
}