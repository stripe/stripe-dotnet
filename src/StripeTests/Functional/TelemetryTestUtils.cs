namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
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

            using var doc = JsonDocument.Parse(payload);
            var metrics = doc.RootElement.GetProperty("last_request_metrics");
            var requestId = metrics.GetProperty("request_id").GetString();
            var duration = metrics.GetProperty("request_duration_ms").GetInt64();

            List<string> usage = null;
            if (metrics.TryGetProperty("usage", out var usageRaw))
            {
                usage = usageRaw.ValueKind == JsonValueKind.Null
                    ? new List<string>()
                    : usageRaw.EnumerateArray().Select(x => x.GetString()).ToList();
            }

            return requestIdMatcher(requestId) && durationMatcher(duration) && usageMatcher(usage);
        }
    }
}
