// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountStatusDetails : StripeEntity<FinancialAccountStatusDetails>
    {
        /// <summary>
        /// Details related to the closure of this FinancialAccount.
        /// </summary>
        [JsonProperty("closed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("closed")]
#endif
        public FinancialAccountStatusDetailsClosed Closed { get; set; }
    }
}
