using System;
using System.Net;

namespace BiblioCommons.Tests.Helpers
{
    public class SimpleServer : IDisposable
    {
        readonly HttpListener _listener;
        readonly Action<HttpListenerContext, string> _handler;
        private static string _responseFileName;

        public static SimpleServer Create(Action<HttpListenerContext, string> handler, string responseFileName)
        {
            var server = new SimpleServer(new HttpListener { Prefixes = { "http://localhost:8080/" } }, handler, responseFileName);
            server.Start();
            return server;
        }

        SimpleServer(HttpListener listener, Action<HttpListenerContext, string> handler, string responseFileName)
        {
            _listener = listener;
            _handler = handler;
            _responseFileName = responseFileName;
        }

        public void Start()
        {
            if (!_listener.IsListening)
            {
                _listener.Start();

                _listener.BeginGetContext(ListenerCallback, _listener);
            } 
        }

        public void ListenerCallback(IAsyncResult result)
        {
            if (_listener.IsListening)
            {
                var context = _listener.EndGetContext(result);
                _handler(context, _responseFileName);
                context.Response.Close();
            }
        }

        public void Dispose()
        {
            _listener.Stop();
            _listener.Close();
        }
    }
}
