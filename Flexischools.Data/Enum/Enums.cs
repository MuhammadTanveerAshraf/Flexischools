using System.ComponentModel;

namespace Flexischools.Data.Enum
{
    public class Enums
    {
        public enum NotificationStatus
        {
            NotSent,
            Sent,
            Failed
        }
        public enum WeekDays
        {
            [Description("Monday")]
            Monday,
            [Description("Tuesday")]
            Tuesday,
            [Description("Wednesday")]
            Wednesday,
            [Description("Thursday")]
            Thursday,
            [Description("Friday")]
            Friday,
            [Description("Saturday")]
            Saturday,
            [Description("Sunday")]
            Sunday
        }
    }
}
