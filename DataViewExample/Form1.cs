using DataViewExample.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataView customersDataView;
        DataView ordersDataView;

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomersTableAdapter.Fill(NorthwindDataSet.Customers);
            OrdersTableAdapter.Fill(NorthwindDataSet.Orders);

            customersDataView = new DataView(NorthwindDataSet.Customers);
            ordersDataView = new DataView(NorthwindDataSet.Orders);

            customersDataView.Sort = "CustomerID";

            CustomersGrid.DataSource = customersDataView;
        }

        private void CustomersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void SetDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = SortTextBox.Text;
            customersDataView.RowFilter = FilterTextBox.Text;
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustomRow = customersDataView.AddNew();

            newCustomRow["CustomerID"] = "WINGT";
            newCustomRow["CompanyName"] = "Wing Tip Toys";

            newCustomRow.EndEdit();
        }

        private void GetOrdersButton_Click(object sender, EventArgs e)
        {
            string selectedCustomerID = (string)CustomersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            DataRowView selectedRow = customersDataView[customersDataView.Find(selectedCustomerID)];
            ordersDataView = selectedRow.CreateChildView(NorthwindDataSet.Relations ["FK_Orders_Customers"]);

            OrdersGrid.DataSource = ordersDataView;
        }
    }
}
