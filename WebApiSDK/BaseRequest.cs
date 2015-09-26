using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiSDK
{
    public class BaseRequest<T> : IRequest<T> where T : BaseResponse
    {
        public virtual string GetUrl()
        {
            throw new NotImplementedException();
        }

        public virtual string Method()
        {
            throw new NotImplementedException();
        }

        public string Post { get; set; }

        public string Url { get; set; }
    }
}
