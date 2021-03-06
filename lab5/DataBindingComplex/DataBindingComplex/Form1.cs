using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingComplex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.NorthwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.NorthwindDataSet.Products);

        }

        private void BindGridButton_Click(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(NorthwindDataSet.Products);
            BindingSource productsBindingSource = new BindingSource(NorthwindDataSet, "Products");
            ProductsGrid.DataSource = productsBindingSource;
            BindingNavigator.BindingSource = productsBindingSource;
        }
    }
}
