using System.Runtime.Serialization;

namespace Project.Core.Enums
{
    public enum CategoryEnum
    {
        [EnumMember(Value = "PlStatement")]
        PlStatement = 1,
        [EnumMember(Value = "GovernmentFinancing")]
        GovernmentFinancing,
        [EnumMember(Value = "OperationalReport")]
        OperationalReport,
        [EnumMember(Value = "Kpi")]
        Kpi,
        [EnumMember(Value = "Budget")]
        Budget,
    }
}
