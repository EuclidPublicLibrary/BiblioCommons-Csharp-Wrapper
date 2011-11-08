using System;

namespace BiblioCommons.Exceptions
{
    public class RestException : Exception
    {
        public string request { get; set; }

        public RestException(string message, string request) : base(message)
        {
            this.request = request;
        }
    }
}
