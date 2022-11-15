using System.Runtime.Serialization;

namespace Project.Core.Enums
{
    public enum StatementReportDataValueTypeEnum : byte
    {
        [EnumMember(Value = "number")]
        Number = 1,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "multiply")]
        Multiply,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "text")]
        Text,
    }
}
