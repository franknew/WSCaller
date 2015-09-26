using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class OrderData
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        public List<OrderInfo> order_info { get; set; }

        /// <summary>
        /// 产品信息
        /// </summary>
        public List<GoodsInfo> goods_info { get; set; }

        /// <summary>
        /// 寄件信息
        /// </summary>
        public List<AddressInfo> address_info { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        public List<LogisticInfo> logistics_info { get; set; }
    }
}
