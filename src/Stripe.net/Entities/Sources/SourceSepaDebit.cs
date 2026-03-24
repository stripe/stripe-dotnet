// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceSepaDebit : StripeEntity<SourceSepaDebit>
    {
        [JsonProperty("bank_code")]
        [STJS.JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("branch_code")]
        [STJS.JsonPropertyName("branch_code")]
        public string BranchCode { get; set; }

        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate_reference")]
        [STJS.JsonPropertyName("mandate_reference")]
        public string MandateReference { get; set; }

        [JsonProperty("mandate_url")]
        [STJS.JsonPropertyName("mandate_url")]
        public string MandateUrl { get; set; }
    }
}
