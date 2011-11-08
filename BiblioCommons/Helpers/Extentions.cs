namespace BiblioCommons
{
    internal static class Extentions
    {
        public static string GetStringValue(this SearchType value)
        {
            string output = null;
            var type = value.GetType();
            var fi = type.GetField(value.ToString());
            var attrs = fi.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];
            if (attrs.Length > 0)
                output = attrs[0].Value;
            return output;
        }
    }
}
