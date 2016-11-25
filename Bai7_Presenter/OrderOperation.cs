using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai7_DataModel;
using Bai7_ViewInterface;
using System.Data.Entity;
namespace Bai7_Presenter
{
    public class OrderOperation
    {
        IviewOrder viewOrder;
        public void Attach(IviewOrder viewOrder)
        {
            this.viewOrder = viewOrder;
        }
        public void DisplayOrderByID(Int32 ID)
        {
            Bai7_MVP_Model entities = new Bai7_MVP_Model();
            Order order = entities.Orders.Where(t => t.OrderID == ID).First();
            List<Order_Detail> ls = entities.Order_Details.Where(t => t.OrderID == ID).ToList();
            viewOrder.DisplayOrders(order, ls);

        }
    }
}
