using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctrlTask
{
    public partial class Form1 : Form
    {
        private object employeesDataView;

        public Form1()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet1.Customers);
            // TODO: This line of code loads data into the 'northwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);

            DataColumn FullName = new DataColumn("FullName");
            FullName.Expression = "LastName + ' ' + FirstName";
            northwindDataSet.Employees.Columns.Add(FullName);

            customersTableAdapter.Fill(northwindDataSet1.Customers);
            customersDataView = new DataView(northwindDataSet1.Customers);
            customersDataView.Sort = "CustomerID";
            dataGridView1.DataSource = customersDataView;
        }
        //добавление новых данных
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn FullNameColumn = new DataGridViewTextBoxColumn();
            FullNameColumn.Name = "FullNameColumn";
            FullNameColumn.HeaderText = "FullName";
            FullNameColumn.DataPropertyName = "FullName";
            employeesDataGridView.Columns.Add(FullNameColumn);
        }

        //удаление новых данных
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                employeesDataGridView.Columns.Remove("FullNameColumn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeesDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }
        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            NorthwindDataSet.EmployeesRow CustRow = (NorthwindDataSet.EmployeesRow)e.Row;
            MessageBox.Show(CustRow.EmployeeID.ToString() + " has been updated");
            northwindDataSet.Employees.Clear();
            sqlDataAdapter1.Fill(northwindDataSet.Employees);
        }
        DataView customersDataView;

        private void AddRow_Click(object sender, EventArgs e)
        {
            DataRowView newCustomRow = customersDataView.AddNew();
            newCustomRow["CustomerID"] = "WINGT";
            newCustomRow["CompanyName"] = "Wing Tip Toys";
            newCustomRow.EndEdit();
        }
    }
}
