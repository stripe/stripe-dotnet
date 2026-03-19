// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertCreditBalanceThresholdFilterOptions : INestedOptions
    {
        /// <summary>
        /// The credit grants for which to configure the credit balance alert.
        /// </summary>
        [JsonProperty("credit_grants")]
        [STJS.JsonPropertyName("credit_grants")]
        public AlertCreditBalanceThresholdFilterCreditGrantsOptions CreditGrants { get; set; }

        /// <summary>
        /// Limit the scope to this credit balance alert only to this customer.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// What type of filter is being applied to this credit balance alert.
        /// One of: <c>customer</c>, or <c>tenant</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
