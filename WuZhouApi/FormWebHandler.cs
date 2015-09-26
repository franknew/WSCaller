using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WuZhouApi
{
    [ComVisible(true)]
    public class FormWebHandler
    {
        private frmLogin handlForm = null;
        public FormWebHandler(WebBrowser browser, frmLogin form)
        {
            this.handlForm = form;
            browser.ObjectForScripting = this;
        }

        public void CloseForm(string code)
        {
            handlForm.request.code = code;
            handlForm.Close();
        }
    }
}
