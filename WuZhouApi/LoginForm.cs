using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WuZhouApi
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class frmLogin : Form
    {
        public TransferTokenRequest request = null;
        private string url = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(string url, TransferTokenRequest request)
        {
            InitializeComponent();
            this.request = request;
            this.url = url;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri(url);
        }
    }
}
