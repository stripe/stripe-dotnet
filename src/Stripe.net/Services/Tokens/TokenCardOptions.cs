// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenCardOptions : INestedOptions
    {
        /// <summary>
        /// City / District / Suburb / Town / Village.
        /// </summary>
        [JsonProperty("address_city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_city")]
#endif
        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided.
        /// </summary>
        [JsonProperty("address_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_country")]
#endif
        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address / PO Box / Company name).
        /// </summary>
        [JsonProperty("address_line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1")]
#endif
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 (Apartment / Suite / Unit / Building).
        /// </summary>
        [JsonProperty("address_line2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line2")]
#endif
        public string AddressLine2 { get; set; }

        /// <summary>
        /// State / County / Province / Region.
        /// </summary>
        [JsonProperty("address_state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_state")]
#endif
        public string AddressState { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("address_zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_zip")]
#endif
        public string AddressZip { get; set; }

        /// <summary>
        /// Required in order to add the card to an account; in all other cases, this parameter is
        /// not used. When added to an account, the card (which must be a debit card) can be used as
        /// a transfer destination for funds in this currency.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Card security code. Highly recommended to always include this value.
        /// </summary>
        [JsonProperty("cvc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc")]
#endif
        public string Cvc { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif
        public string ExpMonth { get; set; }

        /// <summary>
        /// Two- or four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif
        public string ExpYear { get; set; }

        /// <summary>
        /// Cardholder's full name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Contains information about card networks used to process the payment.
        /// </summary>
        [JsonProperty("networks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("networks")]
#endif
        public TokenCardNetworksOptions Networks { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif
        public string Number { get; set; }
    }
}
