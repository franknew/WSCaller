using System;
using System.Collections.Generic;
using System.Text;
using WebApiSDK;

namespace WuZhouApi
{
    public class WuZhouGetRequest<T> : WuZhouBaseRequest<T> where T : WuZhouResponse
    {
        public sealed override string Method()
        {
            return "get";
        }

        public override string GetInterface()
        {
            return base.GetInterface();
        }
    }
}
