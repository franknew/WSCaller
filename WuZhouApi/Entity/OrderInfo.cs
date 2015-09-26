using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class OrderInfo
    {
        /// <summary>
        /// 国际物流编号
        /// </summary>
        public string inter_logistics_number { get; set; }

        /// <summary>
        /// higo系统内部单号
        /// </summary>
        public string higo_internal_logistics_number { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime order_ctime { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime order_send_time { get; set; }
    }
}
