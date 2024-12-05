// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkRestrictionsCompletedSessionsOptions : INestedOptions
    {
        /// <summary>
        /// The maximum number of checkout sessions that can be completed for the
        /// <c>completed_sessions</c> restriction to be met.
        /// </summary>
        [JsonProperty("limit")]
        public long? Limit { get; set; }
    }
}
