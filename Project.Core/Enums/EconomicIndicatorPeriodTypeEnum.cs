using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Project.Core.Enums
{
    public enum EconomicIndicatorPeriodTypeEnum : byte
    {
        [Display(Name = "week")]
        [EnumMember(Value = "week")]
        Week=1,
        [Display(Name = "month")]
        [EnumMember(Value = "month")]
        Month,
        [Display(Name = "year")]
        [EnumMember(Value = "year")]
        Year,    
        [Display(Name = "twoyear")]
        [EnumMember(Value = "twoyear")]
        TwoYear,    
        [Display(Name = "max")]
        [EnumMember(Value = "max")]
        Max,
    }
}
