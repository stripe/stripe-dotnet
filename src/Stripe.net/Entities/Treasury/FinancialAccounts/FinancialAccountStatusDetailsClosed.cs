// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatusDetailsClosed : StripeEntity<FinancialAccountStatusDetailsClosed>
    {
        /// <summary>
        /// The array that contains reasons for a FinancialAccount closure.
        /// One of: <c>account_rejected</c>, <c>closed_by_platform</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reasons")]
        [STJS.JsonPropertyName("reasons")]
        public List<string> Reasons { get; set; }
    }
}
