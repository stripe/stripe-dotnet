// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddressBankAccountAbaAccountHolderAddress : StripeEntity<FinancialAddressBankAccountAbaAccountHolderAddress>
    {
        /// <summary>
        /// City.
        /// </summary>
        [JsonProperty("city")]
        [STJS.JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Address line 1.
        /// </summary>
        [JsonProperty("line1")]
        [STJS.JsonPropertyName("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// Address line 2.
        /// </summary>
        [JsonProperty("line2")]
        [STJS.JsonPropertyName("line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        [JsonProperty("postal_code")]
        [STJS.JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State or province.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Town or suburb.
        /// </summary>
        [JsonProperty("town")]
        [STJS.JsonPropertyName("town")]
        public string Town { get; set; }
    }
}
