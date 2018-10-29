using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azeroth.WCH.Models
{
    public class MenuInfo
    {
        public MenuInfo()
        {
            this.Chirldren = new List<MenuInfo>();
        }
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public Guid Pid { get; set; }
        public UriCategory Category { get; set; }
        public List<MenuInfo> Chirldren { set; get; }
        public MenuInfo Parant { get; set; }

        public bool NotAuthorizition { get; set; }

        public bool Forcus { get; set; }

        public enum UriCategory
        {
            菜单 = 0,
            非菜单 = 1,
        }
        public static List<MenuInfo> GetList()
        {
            List<MenuInfo> lst = new List<MenuInfo>();
            int order = 0;

            MenuInfo value0 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "晴雨表", Order = order++, Pid = Guid.Empty, Url = "/home/index" };
            lst.Add(value0);


            value0 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "工资管理", Order = order++, Pid = Guid.Empty, Url = string.Empty };
            lst.Add(value0);

            MenuInfo value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "员工考勤", Order = order++, Pid = value0.Id, Url = string.Empty };
            lst.Add(value1);
            MenuInfo value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "主记录", Order = order++, Pid = value1.Id, Url = "/wages/attendance/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "明细数据", Order = order++, Pid = value1.Id, Url = "/wages/attendance/detail" };
            lst.Add(value2);

            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "公积金", Order = order++, Pid = value0.Id, Url = string.Empty };
            lst.Add(value1);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "主记录", Order = order++, Pid = value1.Id, Url = "/wages/accumulation/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "明细数据", Order = order++, Pid = value1.Id, Url = "/wages/accumulation/detail" };
            lst.Add(value2);

            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "社保", Order = order++, Pid = value0.Id, Url = string.Empty };
            lst.Add(value1);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "主记录", Order = order++, Pid = value1.Id, Url = "/wages/socialsecurity/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "明细数据", Order = order++, Pid = value1.Id, Url = "/wages/socialsecurity/detail" };
            lst.Add(value2);


            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "基础信息", Order = order++, Pid = value0.Id, Url = string.Empty };
            lst.Add(value1);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "财务核算单位", Order = order++, Pid = value1.Id, Url = "/wages/financeunit/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "员工列表", Order = order++, Pid = value1.Id, Url = "/wages/employee/index" };
            lst.Add(value2);

            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "基本工资", Order = order++, Pid = value0.Id, Url = string.Empty };
            lst.Add(value1);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "调薪", Order = order++, Pid = value1.Id, Url = "/wages/basesalary/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "津贴", Order = order++, Pid = value1.Id, Url = "/wages/bonus/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "奖惩", Order = order++, Pid = value1.Id, Url = "/wages/oncesalary/index" };
            lst.Add(value2);

            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "月工资", Order = order++, Pid = value0.Id, Url = string.Empty };
            lst.Add(value1);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "主列表", Order = order++, Pid = value1.Id, Url = "/wages/monthsalary/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "明细数据", Order = order++, Pid = value1.Id, Url = "/wages/monthsalary/detail" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "审核", Name = "CEO审核工资", Order = order++, Pid = value1.Id, Url = "/wages/monthsalary/approve" };

            value0 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "工作流程", Order = order++, Pid = Guid.Empty, Url = string.Empty };
            lst.Add(value0);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "内部管理", Order = order++, Pid = value0.Id, Url = string.Empty };
            lst.Add(value1);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "请假", Order = order++, Pid = value1.Id, Url = "/flows/leave/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "报销", Order = order++, Pid = value1.Id, Url = "/flows/purchase/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "采购", Order = order++, Pid = value1.Id, Url = "/flows/expenses/index" };
            lst.Add(value2);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "公司业务", Order = order++, Pid = value0.Id, Url = string.Empty };
            lst.Add(value1);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "出差", Order = order++, Pid = value1.Id, Url = "/flows/businesstravel/index" };
            lst.Add(value2);

            value0 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "随笔", Order = order++, Pid = Guid.Empty, Url= "/blogs/index" };
            lst.Add(value0);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "个人中心", Order = order++, Pid = value0.Id, Url = "/author/index" };
            lst.Add(value1);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "新随笔", Order = order++, Pid = value1.Id, Url = "/article/index" };
            lst.Add(value2);
            value2 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "编辑", Order = order++, Pid = value1.Id, Url = "/article/edit" };
            lst.Add(value2);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "详情", Order = order++, Pid = value0.Id, Url = "/article/info" };
            lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "工资发放", Order = order++, Pid = value0.Id, Url = "/ZHGZ/GZFF" };
            //lst.Add(value1);
            //方案
            //MenuInfo value0 = new MenuInfo() { Id = Guid.NewGuid(), Name = "工资", Order = order++, Pid = Guid.Empty, Url = "/Plain" };
            //lst.Add(value0);
            //MenuInfo value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "考勤调整", Order = order++, Pid = value0.Id, Url = "/Plain/SignData" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "考勤审核", Order = order++, Pid = value0.Id, Url = "/Plain/Review" };
            //lst.Add(value1);
            ////value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "考勤调整", Order = order++, Pid = value0.Id, Url = "/Plain/Create" };
            ////lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "公积金", Order = order++, Pid = value0.Id, Url = "/Plain/GJJ" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "公积金审核", Order = order++, Pid = value0.Id, Url = "/Plain/GJJSH" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "社保", Order = order++, Pid = value0.Id, Url = "/Plain/SB" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "社保审核", Order = order++, Pid = value0.Id, Url = "/Plain/SBSH" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "调薪", Order = order++, Pid = value0.Id, Url = "/Plain/TX" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "调薪审核", Order = order++, Pid = value0.Id, Url = "/Plain/TXSH" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "基本工资", Order = order++, Pid = value0.Id, Url = "/Plain/JBGZ" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "基本工资审核", Order = order++, Pid = value0.Id, Url = "/Plain/JBGZSH" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "合成工资", Order = order++, Pid = value0.Id, Url = "/Plain/HCGZ" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "财务经理审核", Order = order++, Pid = value0.Id, Url = "/Plain/HCGZCWSH" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "CFO审核", Order = order++, Pid = value0.Id, Url = "/Plain/HCGZCFOSH" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "工资发放", Order = order++, Pid = value0.Id, Url = "/Plain/FZFF" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "CEO审核", Order = order++, Pid = value0.Id, Url = "/Plain/HCGZCEOSH" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "限制解锁", Order = order++, Pid = value0.Id, Url = "/Plain/Freeze" };
            //lst.Add(value1);

            //value0 = new MenuInfo() { Id = Guid.NewGuid(), Name = "提成", Order = order++, Pid = Guid.Empty, Url = "/Stock" };
            //lst.Add(value0);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "奖金池", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股本变动(展示)", Order = order++, Pid = value0.Id, Url = "/Stock/GBBD" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权架构(展示)", Order = order++, Pid = value0.Id, Url = "/Stock/GQJG" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权新增(扩股)", Order = order++, Pid = value0.Id, Url = "/Stock/Authorizition" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权转让", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权赠予", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权继承", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权代持", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权冻结", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权解锁", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权质押", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权类型变更", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "分红派发", Order = order++, Pid = value0.Id, Url = "/Stock/Index" };
            //lst.Add(value1);

            //value0 = new MenuInfo() { Id = Guid.NewGuid(), Name = "知识", Order = order++, Pid = Guid.Empty, Url = "/Infomation/Index" };
            //lst.Add(value0);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "法律法规", Order = order++, Pid = value0.Id, Url = "/Infomation/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "模板工具", Order = order++, Pid = value0.Id, Url = "/Infomation/Create" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "方法理论", Order = order++, Pid = value0.Id, Url = "/Infomation/Review" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "专家咨询", Order = order++, Pid = value0.Id, Url = "/Infomation/Authorizition" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "专家解读", Order = order++, Pid = value0.Id, Url = "/Infomation/Validate" };

            //value0 = new MenuInfo() { Id = Guid.NewGuid(), Name = "工具", Order = order++, Pid = Guid.Empty, Url = "/Tool/Index" };
            //lst.Add(value0);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "3P分配", Order = order++, Pid = value0.Id, Url = "/Tool/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "价值测算", Order = order++, Pid = value0.Id, Url = "/Tool/Create" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "架构推演", Order = order++, Pid = value0.Id, Url = "/Tool/Review" };

            //value0 = new MenuInfo() { Id = Guid.NewGuid(), Name = "统计", Order = order++, Pid = Guid.Empty, Url = "/Tool/Index" };
            //lst.Add(value0);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股本变动分析", Order = order++, Pid = value0.Id, Url = "/Tool/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权价值分析", Order = order++, Pid = value0.Id, Url = "/Tool/Create" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "突入产出分析", Order = order++, Pid = value0.Id, Url = "/Tool/Review" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "股权全景图", Order = order++, Pid = value0.Id, Url = "/Tool/Authorizition" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "行业大数据分析", Order = order++, Pid = value0.Id, Url = "/Tool/Validate" };

            value0 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "设置", Order = order++, Pid = Guid.Empty, Url = string.Empty };
            lst.Add(value0);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "用户管理", Order = order++, Pid = value0.Id, Url = "/userinfo/index" };
            lst.Add(value1);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "角色管理", Order = order++, Pid = value0.Id, Url = "/roleinfo/index" };
            lst.Add(value1);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "权限管理", Order = order++, Pid = value0.Id, Url = "/actioninfo/index" };
            lst.Add(value1);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "审核组", Order = order++, Pid = value0.Id, Url = "/approvrole/index" };
            lst.Add(value1);
            value1 = new MenuInfo() { Id = Guid.NewGuid(), DisplayName = "系统日志", Order = order++, Pid = value0.Id, Url = "/logs/index" };
            lst.Add(value1);

            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "公司信息", Order = order++, Pid = value0.Id, Url = "/Setting/Index" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "组织架构", Order = order++, Pid = value0.Id, Url = "/Setting/Create" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "合作伙伴", Order = order++, Pid = value0.Id, Url = "/Setting/Review" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "用户权限", Order = order++, Pid = value0.Id, Url = "/Setting/Authorizition" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "参数设置", Order = order++, Pid = value0.Id, Url = "/Setting/Validate" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "操作日志", Order = order++, Pid = value0.Id, Url = "/Setting/Review" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "数据备份", Order = order++, Pid = value0.Id, Url = "/Setting/Authorizition" };

           
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "操作日志", Order = order++, Pid = value0.Id, Url = "/Setting/Review" };
            //lst.Add(value1);
            //value1 = new MenuInfo() { Id = Guid.NewGuid(), Name = "数据备份", Order = order++, Pid = value0.Id, Url = "/Setting/Authorizition" };
            return lst;
        }

        public static List<MenuInfo> GetActiveTree(MenuInfo menu)
        {
            List<MenuInfo> lst = new List<MenuInfo>();
            menu.Forcus = true;
            lst.Add(menu);
            if (menu.Parant != null)
                GetActiveTree(menu.Parant, lst);
            lst.Reverse();
            return lst;
        }

        private static void GetActiveTree(MenuInfo menu, List<MenuInfo> lst)
        {
            menu.Forcus = true;
            lst.Add(menu);
            if (menu.Parant != null)
                GetActiveTree(menu.Parant,lst);
        }
    }
}