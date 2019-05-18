using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZhiMei.CRM.BLL.MemberManage;
using ZhiMei.CRM.Code.Json;
using ZhiMei.CRM.Code.Web;
using ZhiMei.CRM.Domain.Entity.MemberManage;

namespace ZhiMei.CRM.Web.Areas.MemberManage.Controllers
{
    public class MemberController : ControllerBase
    {
        private MemberApp memberApp = new MemberApp();

        /// <summary>
        /// 查询会员列表
        /// </summary>
        /// <param name="pagination">分页信息</param>
        /// <param name="keyword">搜索条件</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = memberApp.GetList(pagination, keyword),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 表单信息
        /// </summary>
        /// <param name="keyValue">操作类型</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = memberApp.GetForm(keyValue);
            return Content(data.ToJson());
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="memberEntity">表单数据</param>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(MemberEntity memberEntity, string keyValue)
        {
            memberApp.SubmitForm(memberEntity, keyValue);
            return Success("操作成功。");
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            memberApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }
    }
}