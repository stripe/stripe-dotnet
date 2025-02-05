// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PayoutTraceId : StripeEntity<PayoutTraceId>
    {
        /// <summary>
        /// Possible values are <c>pending</c>, <c>supported</c>, and <c>unsupported</c>. When
        /// <c>payout.status</c> is <c>pending</c> or <c>in_transit</c>, this will be
        /// <c>pending</c>. When the payout transitions to <c>paid</c>, <c>failed</c>, or
        /// <c>canceled</c>, this status will become <c>supported</c> or <c>unsupported</c> shortly
        /// after in most cases. In some cases, this may appear as <c>pending</c> for up to 10 days
        /// after <c>arrival_date</c> until transitioning to <c>supported</c> or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The trace ID value if <c>trace_id.status</c> is <c>supported</c>, otherwise <c>nil</c>.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
