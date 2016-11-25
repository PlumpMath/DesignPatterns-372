using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace ViewInterface
{
    public interface IViewOrder
    {
        void DisplayOrder(Order order, List<Order_Detail> detail);
    }
}
