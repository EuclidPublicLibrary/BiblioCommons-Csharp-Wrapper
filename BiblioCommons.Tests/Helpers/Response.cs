using System.IO;
using System.Net;
using System.Reflection;

namespace BiblioCommons.Tests.Helpers
{
    public static class Response
    {
        public static void RestResponse_Handler(HttpListenerContext obj, string responseFileName)
        {
            obj.Response.StatusCode = (int)HttpStatusCode.OK;
            obj.Response.ContentType = @"application/json;charset=utf-8";
            obj.Response.OutputStream.WriteStringUtf8(GetInputFile(responseFileName));
        }

        public static void RestResponse_NotFound_Handler(HttpListenerContext obj, string responseFileName)
        {
            obj.Response.StatusCode = (int)HttpStatusCode.NotFound;
            obj.Response.ContentType = @"application/json;charset=utf-8";
            obj.Response.OutputStream.WriteStringUtf8(GetInputFile(responseFileName));
        }

        public static void MasheryResponse_Handler(HttpListenerContext obj, string responseFileName)
        {
            obj.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            obj.Response.ContentType = @"text/xml";
            obj.Response.OutputStream.WriteStringUtf8(GetInputFile(responseFileName));
        }

        private static string GetInputFile(string filename)
        {
            var thisAssembly = Assembly.GetExecutingAssembly();

            const string path = "BiblioCommons.Tests.JsonResponses";

            var sr = new StreamReader(thisAssembly.GetManifestResourceStream(path + "." + filename));

            var resp = sr.ReadToEnd();

            return resp;
        }
    }
}
