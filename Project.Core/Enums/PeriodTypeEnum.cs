using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Project.Core.Enums
{
    public enum PeriodTypeEnum : byte
    {
        [Display(Name = "daily")]
        [EnumMember(Value = "daily")]
        Daily = 1,
        [Display(Name = "weekly")]
        [EnumMember(Value = "weekly")]
        Weekly,
        [Display(Name = "monthly")]
        [EnumMember(Value = "monthly")]
        Monthly,
        [Display(Name = "quarterly")]
        [EnumMember(Value = "quarterly")]
        Quarterly,
        [Display(Name = "yearly")]
        [EnumMember(Value = "yearly")]
        Yearly,
    }
}
