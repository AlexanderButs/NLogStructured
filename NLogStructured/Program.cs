using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using NLog;
using NLog.StructuredLogging.Json;

namespace HttpsWebRequest
{
    public class Program
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public static async Task Main(string[] args)
        {
            Logger.Info("Some message.");

            try
            {
                throw new Exception("Test exception message.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Exception is thrown.");
            }

            EventLogger.Info("Logon by {user} from {ip_address}", "Kenny", "127.0.0.1");

            await Console.In.ReadLineAsync();
        }

        private static readonly ILogger EventLogger = LogManager.GetLogger("Events");
    }
}