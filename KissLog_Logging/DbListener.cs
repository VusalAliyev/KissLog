using KissLog;

namespace KissLog_Logging
{
    public class DbListener : ILogListener
    {
        public ILogListenerInterceptor Interceptor => throw new NotImplementedException();

        public void OnBeginRequest(KissLog.Http.HttpRequest httpRequest)
        {
            throw new NotImplementedException();
        }

        public void OnFlush(FlushLogArgs args)
        {
            // "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36"
            string userAgent = args.HttpProperties.Request.UserAgent;

            // 302
            int statusCode = args.HttpProperties.Response.StatusCode;
        }

        public void OnMessage(LogMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
