using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    /// <summary>
    /// 重量回传
    /// </summary>
    public class WeightCallbackRequest : WuZhouAuthRequest<CommonResponse<WeightCallback>>
    {
        public override string GetInterface()
        {
            return "logistics/weight_callback";
        }

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
    }
}
