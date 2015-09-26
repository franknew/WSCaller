using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class LogisticsExpCallback
    {
        /// <summary>
        /// higo系统内部单号
        /// </summary>
        public string higo_internal_logistics_number { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        public long logistics_exp_type { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string operate_time { get; set; }

        /// <summary>
        /// 异常备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 是否处理成功
        /// </summary>
        public bool process_success { get; set; }
    }
}
