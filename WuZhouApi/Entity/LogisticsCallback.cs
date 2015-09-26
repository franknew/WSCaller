using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class LogisticsCallback
    {
        /// <summary>
        /// higo内部单号
        /// </summary>
        public string higo_internal_logistics_number { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        public long logistics_type { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string operate_time { get; set; }

        /// <summary>
        /// 快递公司
        /// </summary>
        public string express_company { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public string express_number { get; set; }

        /// <summary>
        /// 处理结果，true成功，false失败
        /// </summary>
        public bool process_success { get; set; }
    }
}
