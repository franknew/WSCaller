using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class LogisticInfo
    {
        /// <summary>
        /// 分运单号
        /// </summary>
        public string carrier_code { get; set; }

        /// <summary>
        /// 发件公司
        /// </summary>
        public string carrier_company { get; set; }

        /// <summary>
        /// 发件地址
        /// </summary>
        public string sender_address { get; set; }

        /// <summary>
        /// 发件电话
        /// </summary>
        public string sender_telephone { get; set; }
    }
}
