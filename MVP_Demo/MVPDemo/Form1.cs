using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewInterface;
using Presenter;
using DataModel;

namespace MVPDemo
{
    public partial class Form1 : Form, IViewOrder
    {
        OrderOperation op = new OrderOperation();
        public Form1()
        {
            InitializeComponent();
            op.Attach(this);
        }

        public void DisplayOrder(Order order, List<Order_Detail> detail)
        {
            txtDate.Text = order.OrderDate.ToString();
            txtRequiredDate.Text = order.RequiredDate.ToString();
            dgResult.DataSource = detail;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            op.DisplayOrderByID(Int32.Parse(txtOrderID.Text));
        }
    }
}
