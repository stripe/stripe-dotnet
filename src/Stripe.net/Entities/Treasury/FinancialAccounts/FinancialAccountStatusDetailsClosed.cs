// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountStatusDetailsClosed : StripeEntity<FinancialAccountStatusDetailsClosed>
    {
        /// <summary>
        /// The array that contains reasons for a FinancialAccount closure.
        /// One of: <c>account_rejected</c>, <c>closed_by_platform</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reasons")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reasons")]
#endif
        public List<string> Reasons { get; set; }
    }
}
