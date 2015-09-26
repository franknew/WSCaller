using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class PagingEntity
    {
        public long page_size { get; set; }

        public long page_cur { get; set; }

        public long total_num { get; set; }
    }
}
