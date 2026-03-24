// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCustomerAutomaticIndirectTaxLocation : StripeEntity<AccountConfigurationCustomerAutomaticIndirectTaxLocation>
    {
        /// <summary>
        /// The identified tax country of the customer.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The identified tax state, county, province, or region of the customer.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }
    }
}
