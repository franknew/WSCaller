using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class ShippingFeeCallback
    {
        /// <summary>
        /// 清关批次，格式yyyy-MM-dd
        /// </summary>
        public string clearance_date { get; set; }

        /// <summary>
        /// 总重量
        /// </summary>
        public double total_weight { get; set; }

        /// <summary>
        /// 重量单位，默认KG
        /// </summary>
        public string weight_unit { get; set; }

        /// <summary>
        /// 总运费
        /// </summary>
        public double shipping_fee { get; set; }

        /// <summary>
        /// 运费单位，默认CNY
        /// </summary>
        public string fee_unit { get; set; }

        /// <summary>
        /// 国际快递单号列表，以","分割
        /// </summary>
        public string inter_logistics_numbers { get; set; }

        /// <summary>
        /// higo内部单号列表，以","分割
        /// </summary>
        public string higo_internal_logistics_numbers { get; set; }

        /// <summary>
        /// 操作时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string operate_time { get; set; }

        /// <summary>
        /// 是否操作成功
        /// </summary>
        public bool operate_success { get; set; }
    }
}
