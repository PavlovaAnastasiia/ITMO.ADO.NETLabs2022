using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ctrlTask
{
    public partial class UserControl1 : Form
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindDataSet1.CustomersRow NewRow = (NorthwindDataSet1.CustomersRow)northwindDataSet1.Customers.NewRow();
            NewRow.CustomerID = "";
            NewRow.CompanyName = "";
            NewRow.ContactName = "";
            NewRow.ContactTitle = "";
            NewRow.Address = "";
            NewRow.City = "";
            NewRow.Region = "";
            NewRow.PostalCode = "";
            NewRow.Country = "";
            NewRow.Phone = "";
            NewRow.Fax = "";
            try
            {
                northwindDataSet1.Customers.Rows.Add(NewRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet1.Customers);

        }
    }
}
