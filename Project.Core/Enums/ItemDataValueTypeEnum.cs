using System.Runtime.Serialization;

namespace Project.Core.Enums
{
    public enum ItemDataValueTypeEnum : byte
    {
        [EnumMember(Value = "number")]
        Number = 1,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "multiply")]
        Multiply,
    }
}
