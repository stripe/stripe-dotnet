// File generated from our OpenAPI spec
namespace Stripe.Events
{

/* Unmerged change from project 'Stripe.net(net6.0)'
Before:
    using System.Threading.Tasks;
    using System;
    using Newtonsoft.Json;
After:
    using System;
    using System.Json;
*/

/* Unmerged change from project 'Stripe.net(net7.0)'
Before:
    using System.Threading.Tasks;
    using System;
    using Newtonsoft.Json;
After:
    using System;
    using System.Json;
*/

/* Unmerged change from project 'Stripe.net(net8.0)'
Before:
    using System.Threading.Tasks;
    using System;
    using Newtonsoft.Json;
After:
    using System;
    using System.Json;
*/

/* Unmerged change from project 'Stripe.net(netcoreapp3.1)'
Before:
    using System.Threading.Tasks;
    using System;
    using Newtonsoft.Json;
After:
    using System;
    using System.Json;
*/

/* Unmerged change from project 'Stripe.net(netstandard2.0)'
Before:
    using System.Threading.Tasks;
    using System;
    using Newtonsoft.Json;
After:
    using System;
    using System.Json;
*/

/* Unmerged change from project 'Stripe.net(net461)'
Before:
    using System.Threading.Tasks;
    using System;
    using Newtonsoft.Json;
After:
    using System;
    using System.Json;
*/
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Threading.Tasks;
    using Newtonsoft.Json;

    public class V1BillingMeterErrorReportTriggeredEventData : StripeEntity<V1BillingMeterErrorReportTriggeredEventData>
    {
        /// <summary>
        /// Extra field included in the event's <c>data</c> when fetched from /v2/events.
        /// </summary>
        [JsonProperty("developer_message_summary")]
        public string DeveloperMessageSummary { get; set; }

        /// <summary>
        /// This contains information about why meter error happens.
        /// </summary>
        [JsonProperty("reason")]
        public V1BillingMeterErrorReportTriggeredEventDataReason Reason { get; set; }

        /// <summary>
        /// The end of the window that is encapsulated by this summary.
        /// </summary>
        [JsonProperty("validation_end")]
        public DateTime ValidationEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The start of the window that is encapsulated by this summary.
        /// </summary>
        [JsonProperty("validation_start")]
        public DateTime ValidationStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
