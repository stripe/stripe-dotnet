// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressCredentialsUsBankAccountAccountHolderAddress : StripeEntity<FinancialAddressCredentialsUsBankAccountAccountHolderAddress>
    {
        /// <summary>
        /// The city of the address.
        /// </summary>
        [JsonProperty("city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("city")]
#endif
        public string City { get; set; }

        /// <summary>
        /// The country of the address.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        [JsonProperty("line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line1")]
#endif
        public string Line1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        [JsonProperty("line2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line2")]
#endif
        public string Line2 { get; set; }

        /// <summary>
        /// The postal / zip code of the address.
        /// </summary>
        [JsonProperty("postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("postal_code")]
#endif
        public string PostalCode { get; set; }

        /// <summary>
        /// The state of the address.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        /// <summary>
        /// The town of the address.
        /// </summary>
        [JsonProperty("town")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("town")]
#endif
        public string Town { get; set; }
    }
}
