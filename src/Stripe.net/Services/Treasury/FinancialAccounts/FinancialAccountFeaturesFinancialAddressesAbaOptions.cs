// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountFeaturesFinancialAddressesAbaOptions : INestedOptions
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool? Requested { get; set; }
    }
}
