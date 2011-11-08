using System;

namespace BiblioCommons
{
    public enum SearchType
    {
        [StringValue("keyword")]
        Keyword,

        [StringValue("author")]
        Author,

        [StringValue("subject")]
        Subject,

        [StringValue("tag")]
        Tag,

        [StringValue("series")]
        Series,

        [StringValue("custom")]
        Custom
    }

    public class StringValueAttribute : Attribute
    {
        private readonly string _value;

        public StringValueAttribute(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }
    }
}
