using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class GoodsInfo
    {
        /// <summary>
        /// 品牌
        /// </summary>
        public string brand { get; set; }

        /// <summary>
        /// 商品品类
        /// </summary>
        public string category_name { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public long goods_quantity { get; set; }

        /// <summary>
        /// 商品毛重
        /// </summary>
        public double goods_weight { get; set; }

        /// <summary>
        /// 重量单号，默认KG
        /// </summary>
        public string weight_unit { get; set; }
    }
}
