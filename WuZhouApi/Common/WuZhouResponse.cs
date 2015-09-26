using System;
using System.Collections.Generic;
using System.Text;
using WebApiSDK;

namespace WuZhouApi
{
    public class WuZhouResponse : BaseResponse
    {
        /// <summary>
        /// 返回代码
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string message { get; set; }
    }
}
