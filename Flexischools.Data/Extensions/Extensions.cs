using System.ComponentModel;

namespace Flexischools.Data.Extensions
{
    public static class Extensions
    {
        public static string ToDescription<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var valueString = value.ToString();
            var valueFieldInfo = value.GetType().GetField(valueString);

            if (valueFieldInfo != null)
            {
                var attrs = valueFieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);

                if (attrs != null && attrs.Length > 0)
                {
                    valueString = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return valueString;
        }
    }
}
