using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiSDK
{
    public class PostRequest<T> : BaseRequest<T> where T : BaseResponse
    {
        public override string Method()
        {
            return "post";
        }
    }
}
