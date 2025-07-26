namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Xunit;

    internal class TelemetryTestUtils
    {
        public static bool TelemetryHeaderMatcher(
            HttpHeaders headers,
            Func<string, bool> requestIdMatcher,
            Func<long, bool> durationMatcher,
            Func<List<string>, bool> usageMatcher)
        {
            if (!headers.Contains("X-Stripe-Client-Telemetry"))
            {
                return false;
            }

            var payload = headers.GetValues("X-Stripe-Client-Telemetry").First();

            var deserialized = JToken.Parse(payload);
            var requestId = (string)deserialized["last_request_metrics"]["request_id"];
            var duration = (long)deserialized["last_request_metrics"]["request_duration_ms"];
            var usageRaw = deserialized["last_request_metrics"]["usage"];

            List<string> usage = null;
            if (usageRaw != null)
            {
                usage = usageRaw.Select(x => (string)x).ToList();
            }

            return requestIdMatcher(requestId) && durationMatcher(duration) && usageMatcher(usage);
        }
    }
}
