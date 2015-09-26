using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class WuZhouPagingResponse : WuZhouResponse
    {
        /// <summary>
        /// 页长
        /// </summary>
        public long page_size { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        public long page_cur { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        public long total_num { get; set; }
    }
}
