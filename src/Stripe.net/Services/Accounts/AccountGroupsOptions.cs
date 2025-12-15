// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountGroupsOptions : INestedOptions
    {
        /// <summary>
        /// The group the account is in to determine their payments pricing, and null if the account
        /// is on customized pricing. <a
        /// href="https://docs.stripe.com/connect/platform-pricing-tools">See the Platform pricing
        /// tool documentation</a> for details.
        /// </summary>
        [JsonProperty("payments_pricing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments_pricing")]
#endif
        public string PaymentsPricing { get; set; }
    }
}
