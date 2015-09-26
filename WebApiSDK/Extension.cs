using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiSDK
{
    public class Extension
    {
        public static string StringToChinese(string value)
        {
            string result = "";
            if (!string.IsNullOrEmpty(value) && value.StartsWith(@"\u"))
            {
                string[] strlist = value.Replace("\\", "").Split('u');
                try
                {
                    for (int i = 1; i < strlist.Length; i++)
                    {
                        result += (char)int.Parse(strlist[i], System.Globalization.NumberStyles.HexNumber);
                    }
                }
                catch (FormatException ex)
                {
                    result = ex.Message;
                }
            }
            return result;
        }
    }
}
