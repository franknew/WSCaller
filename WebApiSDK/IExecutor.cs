using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace WebApiSDK
{
    public interface IExecutor
    {
        T Execute<T>(IRequest<T> request, NetworkCredential credential = null) where T : BaseResponse;

        string GetDataString<T>(IRequest<T> request) where T : BaseResponse;

        Dictionary<string, string> GetDataDic<T>(IRequest<T> request) where T : BaseResponse;
    }
}
