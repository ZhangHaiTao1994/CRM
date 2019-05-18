using System.Web.Mvc;
using ZhiMei.CRM.Code.Configs;
using ZhiMei.CRM.Code.Mail;

namespace ZhiMei.CRM.Web.Areas.ExampleManage.Controllers
{
    public class SendMailController : ControllerBase
    {
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SendMail(string account, string title, string content)
        {
            MailHelper mail = new MailHelper();
            mail.MailServer = Configs.GetValue("MailHost");
            mail.MailUserName = Configs.GetValue("MailUserName");
            mail.MailPassword = Configs.GetValue("MailPassword");
            mail.MailName = "致美国际";
            mail.Send(account, title, content);
            return Success("发送成功。");
        }
    }
}
