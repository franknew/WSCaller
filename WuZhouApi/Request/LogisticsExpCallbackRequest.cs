using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class LogisticsExpCallbackRequest : WuZhouAuthRequest<CommonResponse<LogisticsExpCallback>>
    {
        public override string GetInterface()
        {
            return "logistics/logistics_exp_callback";
        }

        /// <summary>
        /// higo系统内部单号
        /// </summary>
        public string higo_internal_logistics_number { get; set; }

        /// <summary>
        /// 异常状态
        /// 2001：香港元朗已入库异常
        /// 2002：香港元朗已出库异常
        /// 2003：等待清关异常
        /// 2004：清关完成异常
        /// 2005：深圳福永已入库异常
        /// 2006：深圳福永已出库异常
        /// 2007：交接第三方物流公司异常
        /// </summary>
        public long logistics_exp_type { get; set; }

        /// <summary>
        /// 操作时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string operate_time { get; set; }

        /// <summary>
        /// 异常备注
        /// </summary>
        public string remark { get; set; }
    }
}
