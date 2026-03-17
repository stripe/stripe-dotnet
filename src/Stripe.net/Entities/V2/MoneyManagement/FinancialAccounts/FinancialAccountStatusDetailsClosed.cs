// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountStatusDetailsClosed : StripeEntity<FinancialAccountStatusDetailsClosed>
    {
        /// <summary>
        /// The forwarding settings for the closed FinancialAccount.
        /// </summary>
        [JsonProperty("forwarding_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("forwarding_settings")]
#endif
        public FinancialAccountStatusDetailsClosedForwardingSettings ForwardingSettings { get; set; }

        /// <summary>
        /// The reason the FinancialAccount was closed.
        /// One of: <c>account_closed</c>, <c>closed_by_platform</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
