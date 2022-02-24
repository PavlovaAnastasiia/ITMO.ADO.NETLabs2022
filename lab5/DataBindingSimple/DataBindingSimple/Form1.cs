using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingSimple
{
    public partial class Form1 : Form
    {
        //private BindingSource productsBindingSource;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);
            productsTableAdapter1.Fill(northwindDataSet1.Products);
            productsBindingSource = new BindingSource(northwindDataSet1, "Products");

            ProductIDTextBox.DataBindings.Add("Text", productsBindingSource, "ProductID");
            ProductNameTextBox2.DataBindings.Add("Text", productsBindingSource, "ProductName");
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }
    }
}
