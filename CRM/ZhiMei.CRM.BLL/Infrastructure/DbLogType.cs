using System.ComponentModel;

namespace ZhiMei.CRM.BLL
{
    public enum DbLogType
    {
        [Description("����")]
        Other = 0,
        [Description("��¼")]
        Login = 1,
        [Description("�˳�")]
        Exit = 2,
        [Description("����")]
        Visit = 3,
        [Description("����")]
        Create = 4,
        [Description("ɾ��")]
        Delete = 5,
        [Description("�޸�")]
        Update = 6,
        [Description("�ύ")]
        Submit = 7,
        [Description("�쳣")]
        Exception = 8,
    }
}

