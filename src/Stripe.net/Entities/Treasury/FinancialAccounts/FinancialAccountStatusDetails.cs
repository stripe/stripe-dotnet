// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatusDetails : StripeEntity<FinancialAccountStatusDetails>
    {
        /// <summary>
        /// Details related to the closure of this FinancialAccount.
        /// </summary>
        [JsonProperty("closed")]
        [STJS.JsonPropertyName("closed")]
        public FinancialAccountStatusDetailsClosed Closed { get; set; }
    }
}
