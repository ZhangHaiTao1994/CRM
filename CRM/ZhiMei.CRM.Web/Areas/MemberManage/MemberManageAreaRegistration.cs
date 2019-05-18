﻿using System.Web.Mvc;

namespace ZhiMei.CRM.Web.Areas.MemberManage
{
    public class MemberManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MemberManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
              this.AreaName + "_Default",
              this.AreaName + "/{controller}/{action}/{id}",
              new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
              new string[] { "ZhiMei.CRM.Web.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}