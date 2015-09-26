using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class OrderList : PagingEntity
    {
        public List<Order> order_data { get; set; }
    }
}
