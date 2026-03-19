// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountGroupsOptions : INestedOptions
    {
        /// <summary>
        /// The group the account is in to determine their payments pricing, and null if the account
        /// is on customized pricing. <a
        /// href="https://docs.stripe.com/connect/platform-pricing-tools">See the Platform pricing
        /// tool documentation</a> for details.
        /// </summary>
        [JsonProperty("payments_pricing")]
        [STJS.JsonPropertyName("payments_pricing")]
        public string PaymentsPricing { get; set; }
    }
}
