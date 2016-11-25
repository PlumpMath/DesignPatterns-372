using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai7_Presenter;
using Bai7_ViewInterface;
using Bai7_DataModel;
namespace Bai7_MVP
{
    public partial class Form1 : Form, IviewOrder
    {
        OrderOperation od = new OrderOperation();
        public Form1()
        {
            InitializeComponent();
            od.Attach(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DisplayOrders(Order order, List<Order_Detail> ls)
        {
            
        }
    }
}
