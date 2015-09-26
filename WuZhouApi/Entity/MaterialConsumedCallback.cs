using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class MaterialConsumedCallback
    {
        /// <summary>
        /// 日期，格式：yyyy-MM-dd
        /// </summary>
        public string date { get; set; }

        /// <summary>
        /// 耗材id
        /// </summary>
        public long material_id { get; set; }

        /// <summary>
        /// 耗材名称
        /// </summary>
        public string material_name { get; set; }

        /// <summary>
        /// 消耗数量
        /// </summary>
        public long consumed_quantity { get; set; }

        /// <summary>
        /// 总重量
        /// </summary>
        public double material_weight { get; set; }

        /// <summary>
        /// 重量单位，默认：KG
        /// </summary>
        public string weight_unit { get; set; }

        /// <summary>
        /// 结算费用
        /// </summary>
        public double material_fee { get; set; }

        /// <summary>
        /// 费用单位，默认：CNY
        /// </summary>
        public string fee_unit { get; set; }

        /// <summary>
        /// 处理结果，true：成功，false：失败
        /// </summary>
        public bool process_success { get; set; }
    }
}
