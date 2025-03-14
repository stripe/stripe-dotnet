// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceAchCreditTransfer : StripeEntity<SourceAchCreditTransfer>
    {
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        [JsonProperty("refund_account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_name")]
#endif
        public string RefundAccountHolderName { get; set; }

        [JsonProperty("refund_account_holder_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_type")]
#endif
        public string RefundAccountHolderType { get; set; }

        [JsonProperty("refund_routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_routing_number")]
#endif
        public string RefundRoutingNumber { get; set; }

        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }

        [JsonProperty("swift_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swift_code")]
#endif
        public string SwiftCode { get; set; }
    }
}
