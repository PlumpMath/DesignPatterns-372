using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai7_DataModel;
namespace Bai7_ViewInterface
{
    public interface IviewOrder
    {
        void DisplayOrders(Order order, List<Order_Detail> ls);
    }
}
