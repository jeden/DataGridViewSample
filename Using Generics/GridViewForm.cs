using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace DataGridViewSample
{
	public partial class GridViewForm : Form
	{
        private List<Customer> _customers;

		public GridViewForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.AutoGenerateColumns = false;

            _customers = new List<Customer>
            {
                new Customer {
			        FirstName = "Antonio",
			        LastName = "Bello",
			        Address = {
                        Street = "My Street", 
                        PostalCode = "32-500",
			            City = "Chrzanow",
                    }},
			    new Customer {
			        FirstName = "Mike",
			        LastName = "Tester",
                    Address = {
                        Street = "His Street",
			            PostalCode = "11223",
			            City = "Rome",
                    }},
                new Customer {
			        FirstName = "Eddie",
			        LastName = "Property",
			        Address = {
                        Street = "Pointer avenue",
			            PostalCode = "55432",
			            City = "London",
                    }}};

            _bindingSource = new BindingSource();
            dataGridView1.DataSource = _bindingSource;
            _bindingSource.DataSource = _customers;
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if ((dataGridView1.Rows[e.RowIndex].DataBoundItem != null) && (dataGridView1.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
				e.Value = BindProperty(dataGridView1.Rows[e.RowIndex].DataBoundItem, dataGridView1.Columns[e.ColumnIndex].DataPropertyName);
		}

		private string BindProperty(object property, string propertyName)
		{
			string retValue;

			retValue = "";

			if (propertyName.Contains("."))
			{
				PropertyInfo[] arrayProperties;
				string leftPropertyName;

				leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
				arrayProperties = property.GetType().GetProperties();

				foreach (PropertyInfo propertyInfo in arrayProperties)
				{
					if (propertyInfo.Name == leftPropertyName)
					{
						retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
						break;
					}
				}
			}
			else
			{
				Type propertyType;
				PropertyInfo propertyInfo;

				propertyType = property.GetType();
				propertyInfo = propertyType.GetProperty(propertyName);
				retValue = propertyInfo.GetValue(property, null).ToString();
			}

			return retValue;
		}

        private void _btnNew_Click(object sender, EventArgs e)
        {
            EditForm form;

            form = new EditForm();
            form.ShowDialog(this);

            if (form.Customer != null)
            {
                _customers.Add(form.Customer);
                _bindingSource.ResetBindings(false);
            }
        }
	}

	public class Customer
	{
		private string firstName;
		private string lastName;
		private Address address = new Address ();

		public string FirstName { get { return firstName; } set { firstName = value; } }
		public string LastName { get { return lastName; } set { lastName = value; } }
		public Address Address { get { return address; } set { address = value; } }
	}

	public class Address
	{
		private string street;
		private string postalCode;
		private string city;

		public string Street { get { return street; } set { street = value; } }
		public string PostalCode { get { return postalCode; } set { postalCode = value; } }
		public string City { get { return city; } set { city = value; } }
	}
}