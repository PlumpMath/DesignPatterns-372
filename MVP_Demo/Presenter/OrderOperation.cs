using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using ViewInterface;

namespace Presenter
{
    public class OrderOperation
    {
        IViewOrder viewOrder;
        public void Attach(IViewOrder viewOrder)
        {
            this.viewOrder = viewOrder;
        }

        public void DisplayOrderByID(int ID)
        {
            NorthwindEntities context = new NorthwindEntities();
            Order order = context.Orders.Where(o => o.OrderID == ID).First();
            List<Order_Detail> detail = order.Order_Details.ToList();
            viewOrder.DisplayOrder(order, detail);
        }
    }
}
