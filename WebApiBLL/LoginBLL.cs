using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Configuration;
using WebApiSDK;
using WuZhouApi;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace WebApiBLL
{
    public class LoginBLL
    {
        public string GetAppCode()
        {
            LoginRequest request = new LoginRequest();
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["appkey"]))
            {
                request.client_id = ConfigurationManager.AppSettings["appkey"];
            }
            else
            {
                throw new Exception("没有配置appkey！");
            }
            request.state = "ok";
            string url = request.GetUrl();
            string querystring = SDKFactory.Executor.GetDataString(request);
            string fullurl = url.TrimEnd('?') + "?" + querystring;
            TransferTokenRequest tokenrequest = new TransferTokenRequest();
            var handle = Process.GetCurrentProcess().MainWindowHandle;
            Form parent = Form.FromHandle(handle) as Form;
            frmLogin form = new frmLogin(fullurl, tokenrequest);
            FormWebHandler handler = new FormWebHandler(form.webBrowser1, form);
            form.ShowDialog(parent);
            return tokenrequest.code;
        }

        public string TransferToken(string code)
        {
            string token = null;
            string username = "";
            string password = "";
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["appkey"]))
            {
                username = ConfigurationManager.AppSettings["appkey"];
            }
            else
            {
                throw new Exception("没有配置appkey！");
            }
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["appsecret"]))
            {
                password = ConfigurationManager.AppSettings["appsecret"];
            }
            else
            {
                throw new Exception("没有配置appsecret！");
            }
            TransferTokenRequest request = new TransferTokenRequest();
            request.code = code;
            request.grant_type = "authorization_code";
            NetworkCredential credential = new NetworkCredential(username, password);
            var response = SDKFactory.Executor.Execute(request, credential);
            Common.CheckResponseError(response, request);
            token = response.data.access_token;
            return token;
        }

        public string RefreshToken(string code)
        {
            string token = null;
            string username = "";
            string password = "";
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["appkey"]))
            {
                username = ConfigurationManager.AppSettings["appkey"];
            }
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["appsecret"]))
            {
                password = ConfigurationManager.AppSettings["appsecret"];
            }
            TransferTokenRequest request = new TransferTokenRequest();
            request.refresh_token = code;
            request.grant_type = "refresh_token";
            NetworkCredential credential = new NetworkCredential(username, password);
            var response = SDKFactory.Executor.Execute(request, credential);
            Common.CheckResponseError(response, request);
            token = response.data.refresh_token;
            return token;
        }

        public string Login()
        {
            string appcode = GetAppCode();
            string token = null;
            if (!string.IsNullOrEmpty(appcode))
            {
                token = TransferToken(appcode);
            }
            return token;
        }
    }
}
