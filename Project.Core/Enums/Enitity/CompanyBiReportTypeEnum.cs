using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Project.Core.Enums.Enitity
{
    public enum CompanyBiReportTypeEnum
    {
        [Display(Name = "snapshot")]
        [EnumMember(Value = "snapshot")]
        Snapshot = 1,
        [Display(Name = "kpi")]
        [EnumMember(Value = "kpi")]
        Kpi,
    }
}
