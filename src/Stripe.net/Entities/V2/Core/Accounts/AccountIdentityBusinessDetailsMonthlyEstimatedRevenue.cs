// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityBusinessDetailsMonthlyEstimatedRevenue : StripeEntity<AccountIdentityBusinessDetailsMonthlyEstimatedRevenue>
    {
        /// <summary>
        /// Estimated monthly revenue amount in minor currency units (for example, '123' for 1.23
        /// USD).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }
    }
}
