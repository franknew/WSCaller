using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    /// <summary>
    /// 查询运单信息
    /// </summary>
    public class QueryOrderRequest : WuZhouAuthRequest<CommonResponse<OrderList>>
    {
        public override string GetInterface()
        {
            return "order/order_list_wzhs";
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        public long page_curr { get; set; }

        /// <summary>
        /// 发货起始时间
        /// </summary>
        public string send_time_start { get; set; }

        /// <summary>
        /// 发货终止时间
        /// </summary>
        public string send_time_end { get; set; }
    }
}
