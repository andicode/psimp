using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    public class ReportList
    {
        public static List<ReportNode> GetReports()
        {
            List<ReportNode> reports = new List<ReportNode>();
            reports.Add(new ReportNode { Name = "人事台账一览表", ID = "3" });
            reports.Add(new ReportNode { Name = "人员证件汇总表", ID = "4" });
            reports.Add(new ReportNode { Name = "注册情况统计表", ID = "5" });
            reports.Add(new ReportNode { Name = "人员意外险汇总表", ID = "6" });
            reports.Add(new ReportNode { Name = "工程信息表", ID = "7" });
            reports.Add(new ReportNode { Name = "项目?", ID = "8" });
            reports.Add(new ReportNode { Name = "项目人员变更一览表", ID = "9" });
            reports.Add(new ReportNode { Name = "项目车辆汇总表", ID = "10" });
            reports.Add(new ReportNode { Name = "项目车辆租赁一览表", ID = "11" });
            reports.Add(new ReportNode { Name = "项目车辆贷款一览表", ID = "12" });
            reports.Add(new ReportNode { Name = "项目车辆还贷信息汇总表", ID = "13" });
            reports.Add(new ReportNode { Name = "项目车辆维修信息一览表", ID = "14" });
            reports.Add(new ReportNode { Name = "车辆日常费用一览表", ID = "15" });
            reports.Add(new ReportNode { Name = "项目资产汇总表", ID = "16" });
            reports.Add(new ReportNode { Name = "项目资产明细表", ID = "17" });

            return reports;
        }
    }
    public class ReportNode {
        public string Name { get; set; }
        public string  ID { get; set; }
    }
}
