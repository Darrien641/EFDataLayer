using EFDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CustChoose : Form
    {
        
        public CustChoose()
        {
            InitializeComponent();
            GetCustomers();
        }
        public void GetCustomers()
        {
            NameEdit.Enabled = false;
            AddrEdit.Enabled = false;
            CustomerDataContext CDC = new CustomerDataContext();
            dataGridView1.DataSource =
                CDC.Customers.Join(CDC.Addresses, c => c.CustomerId, a => a.Customer.CustomerId, (a, c) => 
                new { a.CustomerId, a.Firstname, a.Lastname, c.Street, c.City, c.State, c.Zip }).ToList().AsReadOnly();
            dataGridView1.Columns["CustomerID"].Visible = false;
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //int SelectedRow = dataGridView1.CurrentRow.Index;
            int CustID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            FirstNameForm EditFirst = new FirstNameForm(CustID);
            
            EditFirst.Show();
            this.Hide();

        }

        private void AddrEdit_Click(object sender, EventArgs e)
        {
            //int SelectedRow = dataGridView1.CurrentRow.Index;
            int CustID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //send cudtomer and address objects to addrEdit form to be used and displayed
            AddrEditForm addrEdit = new AddrEditForm(CustID);
            addrEdit.Show();
            this.Hide();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            AddrEdit.Enabled = false;
            NameEdit.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddrEdit.Enabled = true;
            NameEdit.Enabled = true;
        } 
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
