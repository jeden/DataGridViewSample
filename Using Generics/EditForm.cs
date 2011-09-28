using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewSample
{
    public partial class EditForm : Form
    {
        public Customer Customer { get; set; }

        public EditForm()
        {
            InitializeComponent();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            Customer = new Customer
            {
                FirstName = _editFirstName.Text,
                LastName = _editLastName.Text,
                Address =
                {
                    Street = _editStreet.Text,
                    PostalCode = _editPostalCode.Text,
                    City = _editCity.Text,
                }
            };

            Close();
        }
    }
}
