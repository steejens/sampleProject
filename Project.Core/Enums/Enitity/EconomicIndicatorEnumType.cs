using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Project.Core.Enums.Enitity
{
    public enum EconomicIndicatorEnumType
    {
        [Display(Name = "bitcoin")]
        [EnumMember(Value = "bitcoin")]
        BitCoin = 1,
        [Display(Name = "brentCrudeOil")]
        [EnumMember(Value = "brentCrudeOil")]
        BrentCrudeOil,
        [Display(Name = "euroUsd")]
        [EnumMember(Value = "euroUsd")]
        EuroUsd,
        [Display(Name = "gold")]
        [EnumMember(Value = "gold")]
        Gold,
        [Display(Name = "silver")]
        [EnumMember(Value = "silver")]
        Silver,
        [Display(Name = "azeriLightOil")]
        [EnumMember(Value = "azeriLightOil")]
        AzeriLightOil,
        [Display(Name = "wheat")]
        [EnumMember(Value = "wheat")]
        Wheat
    }
}
