using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("Hji+g0c2wBQ7GBmJvqy71heMzzisqCIcPdUER2YnX6rVAQRyk0bD6yoHtsrEk7+WSBO+1OTAuRqRx4QbdE170OHL/7pNm0rvwFkXiEKJk36kbbaT9A2UX6yjzDYXQQYx28d0rY1jR0OX2Fo90qMtoAdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("U98df62bcbaa9e086bd9fac329dc6cf50", "TEST");
            bot.PushMessage("U98df62bcbaa9e086bd9fac329dc6cf50", 1, 14);
            bot.PushMessage("U98df62bcbaa9e086bd9fac329dc6cf50", new Uri("https://i.pinimg.com/originals/be/2b/83/be2b83efcaa929a406f765db3a6633d7.png"));
        }
    }
}