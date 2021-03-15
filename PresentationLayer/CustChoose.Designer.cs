
namespace PresentationLayer
{
    partial class CustChoose
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameEdit = new System.Windows.Forms.Button();
            this.AddrEdit = new System.Windows.Forms.Button();
            this.NameUpdate = new System.Windows.Forms.Label();
            this.AddrUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(641, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // NameEdit
            // 
            this.NameEdit.Location = new System.Drawing.Point(141, 65);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(81, 23);
            this.NameEdit.TabIndex = 1;
            this.NameEdit.Text = "Name Edit";
            this.NameEdit.UseVisualStyleBackColor = true;
            this.NameEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddrEdit
            // 
            this.AddrEdit.Location = new System.Drawing.Point(398, 65);
            this.AddrEdit.Name = "AddrEdit";
            this.AddrEdit.Size = new System.Drawing.Size(109, 23);
            this.AddrEdit.TabIndex = 2;
            this.AddrEdit.Text = "Edit Address";
            this.AddrEdit.UseVisualStyleBackColor = true;
            this.AddrEdit.Click += new System.EventHandler(this.AddrEdit_Click);
            // 
            // NameUpdate
            // 
            this.NameUpdate.AutoSize = true;
            this.NameUpdate.Location = new System.Drawing.Point(35, 110);
            this.NameUpdate.Name = "NameUpdate";
            this.NameUpdate.Size = new System.Drawing.Size(234, 15);
            this.NameUpdate.TabIndex = 3;
            this.NameUpdate.Text = "First Name Has Been Successfully Updated!";
            this.NameUpdate.Visible = false;
            // 
            // AddrUpdate
            // 
            this.AddrUpdate.AutoSize = true;
            this.AddrUpdate.Location = new System.Drawing.Point(398, 109);
            this.AddrUpdate.Name = "AddrUpdate";
            this.AddrUpdate.Size = new System.Drawing.Size(219, 15);
            this.AddrUpdate.TabIndex = 4;
            this.AddrUpdate.Text = "Address Has Been Successfully Updated!";
            // 
            // CustChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 448);
            this.Controls.Add(this.AddrUpdate);
            this.Controls.Add(this.NameUpdate);
            this.Controls.Add(this.AddrEdit);
            this.Controls.Add(this.NameEdit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustChoose";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NameEdit;
        private System.Windows.Forms.Button AddrEdit;
        private System.Windows.Forms.Label NameUpdate;
        private System.Windows.Forms.Label AddrUpdate;
    }
}

