using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class CommonResponse<T> : WuZhouResponse where T: new()
    {
        public T data { get; set; }
    }
}
