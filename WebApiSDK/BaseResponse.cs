using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiSDK
{
    public abstract class BaseResponse
    {
        public virtual string Body { get; set; }
    }

    public sealed class BaseResponseShadow : BaseResponse
    {
        public override string Body { get; set; }

        public object Data { get; set; }
    }
}
