using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class AddressInfo
    {
        /// <summary>
        /// 收件人
        /// </summary>
        public string receiver_name { get; set; }

        /// <summary>
        /// 收件人手机
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 收件人座机
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        public string district { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        public string street { get; set; }
    }
}
