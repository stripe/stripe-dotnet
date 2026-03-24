// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatusDetailsClosed : StripeEntity<FinancialAccountStatusDetailsClosed>
    {
        /// <summary>
        /// The forwarding settings for the closed FinancialAccount.
        /// </summary>
        [JsonProperty("forwarding_settings")]
        [STJS.JsonPropertyName("forwarding_settings")]
        public FinancialAccountStatusDetailsClosedForwardingSettings ForwardingSettings { get; set; }

        /// <summary>
        /// The reason the FinancialAccount was closed.
        /// One of: <c>account_closed</c>, <c>closed_by_platform</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
