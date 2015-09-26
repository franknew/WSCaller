using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class WuZhouAuthRequest<T> : WuZhouPostRequest<T> where T : WuZhouResponse
    {
        public string access_token { get; set; }

        public string format { get; set; }

        public string version
        {
            get { return "0.1"; }
        }
    }
}
