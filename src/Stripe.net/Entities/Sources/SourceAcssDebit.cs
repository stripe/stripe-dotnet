// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceAcssDebit : StripeEntity<SourceAcssDebit>
    {
        [JsonProperty("bank_address_city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_address_city")]
#endif

        public string BankAddressCity { get; set; }

        [JsonProperty("bank_address_line_1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_address_line_1")]
#endif

        public string BankAddressLine1 { get; set; }

        [JsonProperty("bank_address_line_2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_address_line_2")]
#endif

        public string BankAddressLine2 { get; set; }

        [JsonProperty("bank_address_postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_address_postal_code")]
#endif

        public string BankAddressPostalCode { get; set; }

        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif

        public string BankName { get; set; }

        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif

        public string Category { get; set; }

        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif

        public string Country { get; set; }

        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif

        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif

        public string Last4 { get; set; }

        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif

        public string RoutingNumber { get; set; }
    }
}
