using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiSDK
{
    public interface IRequest<T> where T : BaseResponse
    {
        string GetUrl();

        string Method();
    }
}
