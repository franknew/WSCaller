using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using WebApiSDK;
using WuZhouApi;

namespace WebApiBLL
{
    public class Common
    {
        public static R CheckResponseError<T, R>(WuZhouAuthRequest<R> request, R response, ref string token) where T : new()
            where R : WuZhouResponse
        {
            switch (response.code)
            {
                case 400109:
                case 500103:
                    LoginBLL bll = new LoginBLL();
                    token = bll.Login();
                    if (string.IsNullOrEmpty(token))
                    {
                        return response;
                    }
                    request.access_token = token;
                    response = SDKFactory.Executor.Execute(request);
                    CheckResponseError<T, R>(request, response, ref token);
                    return response;
                case 0:
                    return response;
                default:
                    throw new Exception(response.message);
            }
        }

        public static string CheckResponseError<T>(WuZhouResponse response, WuZhouPostRequest<CommonResponse<T>> request) where T : new()
        {
            switch (response.code)
            {
                case 0:
                    return null;
                default:
                    throw new Exception(response.message);

            }
        }

        public static string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
    }
}
