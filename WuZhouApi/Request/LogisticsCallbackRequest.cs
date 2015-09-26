using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    /// <summary>
    /// 物流回传
    /// </summary>
    public class LogisticsCallbackRequest : WuZhouAuthRequest<CommonResponse<LogisticsCallback>>
    {
        public override string GetInterface()
        {
            return "logistics/logistics_callback";
        }

        /// <summary>
        /// higo内部单号
        /// </summary>
        public string higo_internal_logistics_number { get; set; }

        /// <summary>
        /// 物流状态
        /// 1001：香港元朗已入库
        /// 1002：香港元朗已出库
        /// 1003：等待清关
        /// 1004：清关完成
        /// 1005：深圳福永已入库
        /// 1006：深圳福永已出库
        /// 1007：交接第三方物流公司
        /// </summary>
        public long logistics_type { get; set; }

        public string operate_time { get; set; }

        /// <summary>
        /// 快递公司，logistics_type：1007时必传
        /// </summary>
        public string express_company { get; set; }

        /// <summary>
        /// 快递单号，logistics_type：1007时必传
        /// </summary>
        public string express_number { get; set; }
    }
}
