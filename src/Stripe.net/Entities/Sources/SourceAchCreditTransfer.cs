// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceAchCreditTransfer : StripeEntity<SourceAchCreditTransfer>
    {
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("refund_account_holder_name")]
        [STJS.JsonPropertyName("refund_account_holder_name")]
        public string RefundAccountHolderName { get; set; }

        [JsonProperty("refund_account_holder_type")]
        [STJS.JsonPropertyName("refund_account_holder_type")]
        public string RefundAccountHolderType { get; set; }

        [JsonProperty("refund_routing_number")]
        [STJS.JsonPropertyName("refund_routing_number")]
        public string RefundRoutingNumber { get; set; }

        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("swift_code")]
        [STJS.JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
