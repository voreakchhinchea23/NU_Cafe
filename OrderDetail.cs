using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NU_Cafe
{
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        public void DisplayOrderDetails(DataTable dataTable)
        {
            // Bind the DataTable to the DataGridView
            dtgOrderDetails.DataSource = dataTable.DefaultView;

            // Optionally, set column headers for better readability
            dtgOrderDetails.Columns["OrderDetailID"].HeaderText = "Order Detail ID";
            dtgOrderDetails.Columns["OrderId"].HeaderText = "Order ID";
            dtgOrderDetails.Columns["ProductID"].HeaderText = "Product ID";
            dtgOrderDetails.Columns["Quantity"].HeaderText = "Quantity";
            dtgOrderDetails.Columns["UnitPrice"].HeaderText = "Unit Price";
            
        }
        
    }
}
