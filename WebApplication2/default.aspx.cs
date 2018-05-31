using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "Hji+g0c2wBQ7GBmJvqy71heMzzisqCIcPdUER2YnX6rVAQRyk0bD6yoHtsrEk7+WSBO+1OTAuRqRx4QbdE170OHL/7pNm0rvwFkXiEKJk36kbbaT9A2UX6yjzDYXQQYx28d0rY1jR0OX2Fo90qMtoAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U98df62bcbaa9e086bd9fac329dc6cf50";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}