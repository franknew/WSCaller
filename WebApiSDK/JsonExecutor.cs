
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SOAFramework.Library;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Net;

namespace WebApiSDK
{
    public class JsonExecutor : IExecutor
    {
        public T Execute<T>(IRequest<T> request, NetworkCredential credential = null) where T : BaseResponse
        {
            string url = request.GetUrl();
            T t = Activator.CreateInstance<T>();
            string poststring = GetDataString<T>(request);
            if (request is BaseRequest<T>)
            {
                var req = request as BaseRequest<T>;
                req.Post = poststring;
                req.Url = url;
            }
            string result = null;
            if (request.Method() == "get")
            {
                string fullurl = url.TrimEnd('?') + "?" + poststring;
                var args = GetDataDic<T>(request);
                result = HttpHelper.Get(fullurl);
            }
            else
            {
                byte[] bytepost = Encoding.UTF8.GetBytes(poststring);
                result = HttpHelper.Post(url, bytepost, -1, "application/x-www-form-urlencoded", credential);
            }
            BaseResponseShadow shadow = JsonConvert.DeserializeObject<BaseResponseShadow>(result);
            t = JsonConvert.DeserializeObject<T>(result);
            t.Body = result;
            var responseType = typeof(T);
            PropertyInfo[] responseProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            if (responseProperties != null && responseProperties.Length > 0)
            {
                object data = null;
                if (shadow.Data is JObject)
                {
                    data = (shadow.Data as JObject).ToObject(responseProperties[0].PropertyType);
                }
                else if (shadow.Data is JArray)
                {
                    data = (shadow.Data as JArray).ToObject(responseProperties[0].PropertyType);
                }
                else
                {
                    data = shadow.Data;
                }
                responseProperties[0].SetValue(t, data, null);
            }

            return t;
        }

        public string GetDataString<T>(IRequest<T> request) where T : BaseResponse
        {
            var requestType = request.GetType();
            PropertyInfo[] properties = requestType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder postbuilder = new StringBuilder();
            Dictionary<string, string> args = new Dictionary<string, string>();
            foreach (var property in properties)
            {
                string name = property.Name;
                object value = property.GetValue(request, null);
                if (value != null)
                {
                    args[name] = value.ToString();
                    postbuilder.AppendFormat("{0}={1}&", name, value.ToString());
                }
            }
            string poststring = postbuilder.ToString().TrimEnd('&');
            return poststring;
        }

        public Dictionary<string, string> GetDataDic<T>(IRequest<T> request) where T : BaseResponse
        {
            var requestType = request.GetType();
            PropertyInfo[] properties = requestType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder postbuilder = new StringBuilder();
            Dictionary<string, string> args = new Dictionary<string, string>();
            foreach (var property in properties)
            {
                string name = property.Name;
                object value = property.GetValue(request, null);
                if (value != null)
                {
                    args[name] = value.ToString();
                }
            }
            return args;
        }
    }
}
