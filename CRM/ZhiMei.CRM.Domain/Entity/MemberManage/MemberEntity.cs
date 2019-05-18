using System;

namespace ZhiMei.CRM.Domain.Entity.MemberManage
{
    /// <summary>
    /// 会员类
    /// </summary>
    public class MemberEntity : IEntity<MemberEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string F_Id { get; set; }
        /// <summary>
        /// 会员编码
        /// </summary>
        public string F_MemberCode { get; set; }
        /// <summary>
        /// 会员名称
        /// </summary>
        public string F_MemberName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool F_Gender { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime F_Birthday { get; set; }
        /// <summary>
        /// 微信名称
        /// </summary>
        public string F_WeChatName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string F_TelePhoneNo { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string F_Address { get; set; }
        /// <summary>
        /// 地址省
        /// </summary>
        public string F_AddressProvinceId { get; set; }
        /// <summary>
        /// 地址市
        /// </summary>
        public string F_AddressCityId { get; set; }
        /// <summary>
        /// 地址区
        /// </summary>
        public string F_AddressDistrictId { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal F_Amount { get; set; }
        /// <summary>
        /// 上次购买时间
        /// </summary>
        public DateTime? F_LastPurchaseDate { get; set; }
        /// <summary>
        /// 所属人
        /// </summary>
        public string F_BelongerId { get; set; }
        /// <summary>
        /// 所属人微信
        /// </summary>
        public string F_BelongerWeChatID { get; set; }
        /// <summary>
        /// 所属人微信昵称
        /// </summary>
        public string F_BelongerWeChatName { get; set; }
        /// <summary>
        /// 未跟进天数
        /// </summary>
        public int F_NoFollowUpDays { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string F_Remark { get; set; }
        /// <summary>
        /// 客户类型
        /// </summary>
        public string F_CustomerType { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string F_Status { get; set; }
        /// <summary>
        /// 删除标志
        /// </summary>
        public bool? F_DeleteMark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? F_CreatorTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string F_CreatorUserId { get; set; }
        /// <summary>
        /// 上次修改时间
        /// </summary>
        public DateTime? F_LastModifyTime { get; set; }
        /// <summary>
        /// 上次修改人
        /// </summary>
        public string F_LastModifyUserId { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? F_DeleteTime { get; set; }
        /// <summary>
        /// 删除人
        /// </summary>
        public string F_DeleteUserId { get; set; }
    }
}
