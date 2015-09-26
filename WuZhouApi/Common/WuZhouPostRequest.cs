using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class WuZhouPostRequest<T> : WuZhouBaseRequest<T> where T : WuZhouResponse
    {
        public sealed override string Method()
        {
            return "post";
        }

        public override string GetInterface()
        {
            return base.GetInterface();
        }
    }
}
