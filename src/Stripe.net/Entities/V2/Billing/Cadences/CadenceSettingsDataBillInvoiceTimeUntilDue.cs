// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSettingsDataBillInvoiceTimeUntilDue : StripeEntity<CadenceSettingsDataBillInvoiceTimeUntilDue>
    {
        /// <summary>
        /// The interval unit for the time until due.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of interval units. For example, if interval=day and interval_count=30, the
        /// invoice will be due in 30 days.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long IntervalCount { get; set; }
    }
}
