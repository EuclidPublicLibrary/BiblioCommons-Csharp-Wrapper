using System;

namespace BiblioCommons.Exceptions
{
    public class MasheryException : Exception
    {
        public string request { get; set; }

        public MasheryException(string message, string request) : base(message)
        {
            this.request = request;
        }
    }
}
