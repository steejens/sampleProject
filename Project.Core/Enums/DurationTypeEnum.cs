namespace Project.Core.Enums
{
    public enum DurationTypeEnum
    {
        Week = 1,
        Month,
        Quarter,
        Year,
    }

    public static class DurationTypeExtension
    {
        public static PeriodTypeEnum ToPeriodTypeEnum(this DurationTypeEnum @enum)
        {

            switch (@enum)
            {
                case DurationTypeEnum.Month:
                    return PeriodTypeEnum.Monthly;
                case DurationTypeEnum.Quarter:
                    return PeriodTypeEnum.Quarterly;
                case DurationTypeEnum.Week:
                    return PeriodTypeEnum.Weekly;
                case DurationTypeEnum.Year:
                    return PeriodTypeEnum.Yearly;

                default:
                    return PeriodTypeEnum.Monthly;
            }
        }
    }
}
