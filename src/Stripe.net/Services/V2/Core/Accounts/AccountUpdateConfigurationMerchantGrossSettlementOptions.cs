// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMerchantGrossSettlementOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the payment method to use for gross settlement payouts.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Whether to collect a payment method for gross settlement.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
        [STJS.JsonPropertyName("payment_method_collection")]
        public string PaymentMethodCollection { get; set; }
    }
}
