using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class Order
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        public OrderInfo order_info { get; set; }

        /// <summary>
        /// 产品信息
        /// </summary>
        public List<GoodsInfo> goods_info { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        public AddressInfo address_info { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        public LogisticInfo logistics_info { get; set; }
    }
}
