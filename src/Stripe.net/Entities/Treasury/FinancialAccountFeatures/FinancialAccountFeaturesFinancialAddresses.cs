// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountFeaturesFinancialAddresses : StripeEntity<FinancialAccountFeaturesFinancialAddresses>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling the ABA address feature.
        /// </summary>
        [JsonProperty("aba")]
        [STJS.JsonPropertyName("aba")]
        public FinancialAccountFeaturesFinancialAddressesAba Aba { get; set; }
    }
}
