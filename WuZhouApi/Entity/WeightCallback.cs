using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class WeightCallback
    {
        /// <summary>
        /// 国际快递单号
        /// </summary>
        public string inter_logistics_number { get; set; }

        /// <summary>
        /// 包裹重量
        /// </summary>
        public double package_weight { get; set; }

        /// <summary>
        /// 重量单位，默认KG
        /// </summary>
        public string weight_unit { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string operate_time { get; set; }

        /// <summary>
        /// 处理结果，true成功，false失败
        /// </summary>
        public bool operate_success { get; set; }
    }
}
