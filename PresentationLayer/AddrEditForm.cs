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

namespace PresentationLayer
{
    public partial class AddrEditForm : Form
    {
        readonly CustomerDataContext CDC = new CustomerDataContext();
        readonly int CustomerID;
        public AddrEditForm(int custID)
        {
            InitializeComponent();
            CustomerID = custID;
        }
        //use customer and address to edit address
        //save changes to data base
        private void AddrEditForm_Load(object sender, EventArgs e)
        {
            var UpdatableCust = CDC.Customers.Single(c => c.CustomerId == CustomerID);
            var UpdatableAddr = CDC.Addresses.Single(a => a.CustomerId == CustomerID);
            label1.Text = $"Editing Address of Customer: {UpdatableCust.Firstname} {UpdatableCust.Lastname}";
            StreetBox.Text = UpdatableAddr.Street;
            CityBox.Text = UpdatableAddr.City;
            StateBox.Text = UpdatableAddr.State;
            ZipBox.Text = UpdatableAddr.Zip;

        }

        private void AddrUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StreetBox.Text) || string.IsNullOrWhiteSpace(StreetBox.Text)
                || string.IsNullOrEmpty(CityBox.Text) || string.IsNullOrWhiteSpace(CityBox.Text)
                || string.IsNullOrEmpty(StateBox.Text) || string.IsNullOrWhiteSpace(StateBox.Text)
                || string.IsNullOrEmpty(ZipBox.Text) || string.IsNullOrWhiteSpace(ZipBox.Text))
            {
                Required.Visible = true;
            }
            else 
            {
                Required.Visible = false;
                Address NewAddr = CDC.Addresses.Single(a => a.CustomerId == CustomerID);
                NewAddr.Street = StreetBox.Text;
                NewAddr.City = CityBox.Text;
                NewAddr.State = StateBox.Text;
                NewAddr.Zip = ZipBox.Text;
                CDC.SaveChanges();
                this.Close();
            }
        }

        private void StateBox_TextChanged(object sender, EventArgs e)
        {
            if (StateBox.Text.Length > 2)
            {
                StateReq.Visible = true;
            }
            else
            {
                StateReq.Visible = false;
            }
        }

        private void AddrEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustChoose CustView = new CustChoose();
            CustView.Show();
         
        }
    }
}
