using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace PresentationLayer
{
    public partial class FirstNameForm : Form
    {
        CustomerDataContext CDC = new CustomerDataContext();
        int CustomerID;

        public FirstNameForm(int CustID)
        {
            InitializeComponent();
            CustomerID = CustID;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FNameBox.Text) || string.IsNullOrWhiteSpace(FNameBox.Text))
            {
                EmptyWarning.Visible = true;
            }
            else
            {
                CDC.Database.ExecuteSqlRaw("Execute dbo.UpdateCustFirstName @ID, @NewFirstName",
                  new SqlParameter("ID", CustomerID), new SqlParameter("NewFirstName", FNameBox.Text.ToString()));
                CustChoose CustView = new CustChoose();
                CustView.Show();
                this.Close();
            }
        }

        private void FirstNameForm_Load(object sender, EventArgs e)
        {
            Customer FNameUpdate = CDC.Customers.Single(c => c.CustomerId == CustomerID);
            FNameBox.Text = FNameUpdate.Firstname;
            LNameBox.Text = FNameUpdate.Lastname;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
