// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceSepaDebit : StripeEntity<SourceSepaDebit>
    {
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif

        public string BankCode { get; set; }

        [JsonProperty("branch_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branch_code")]
#endif

        public string BranchCode { get; set; }

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

        [JsonProperty("mandate_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_reference")]
#endif

        public string MandateReference { get; set; }

        [JsonProperty("mandate_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_url")]
#endif

        public string MandateUrl { get; set; }
    }
}
