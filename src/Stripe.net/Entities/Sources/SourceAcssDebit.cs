// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceAcssDebit : StripeEntity<SourceAcssDebit>
    {
        [JsonProperty("bank_address_city")]
        [STJS.JsonPropertyName("bank_address_city")]
        public string BankAddressCity { get; set; }

        [JsonProperty("bank_address_line_1")]
        [STJS.JsonPropertyName("bank_address_line_1")]
        public string BankAddressLine1 { get; set; }

        [JsonProperty("bank_address_line_2")]
        [STJS.JsonPropertyName("bank_address_line_2")]
        public string BankAddressLine2 { get; set; }

        [JsonProperty("bank_address_postal_code")]
        [STJS.JsonPropertyName("bank_address_postal_code")]
        public string BankAddressPostalCode { get; set; }

        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("category")]
        [STJS.JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
