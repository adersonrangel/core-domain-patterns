namespace Inkra.Parqueadero.Api.Logging
{
    public class LoggingAdapter : ILoggingAdapter
    {
        public readonly ILoggingAdapter loggingAdapter;

        public LoggingAdapter(ILoggingAdapter loggingAdapter)
        {
            this.loggingAdapter = loggingAdapter;
        }

       
    }
}
