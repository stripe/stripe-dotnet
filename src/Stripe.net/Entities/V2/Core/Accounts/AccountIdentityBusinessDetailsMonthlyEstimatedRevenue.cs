// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityBusinessDetailsMonthlyEstimatedRevenue : StripeEntity<AccountIdentityBusinessDetailsMonthlyEstimatedRevenue>
    {
        /// <summary>
        /// Estimated monthly revenue amount in minor currency units (for example, '123' for 1.23
        /// USD).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public AccountIdentityBusinessDetailsMonthlyEstimatedRevenueAmount Amount { get; set; }
    }
}
