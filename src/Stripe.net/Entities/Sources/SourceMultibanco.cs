// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceMultibanco : StripeEntity<SourceMultibanco>
    {
        [JsonProperty("entity")]
        [STJS.JsonPropertyName("entity")]
        public string Entity { get; set; }

        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonProperty("refund_account_holder_address_city")]
        [STJS.JsonPropertyName("refund_account_holder_address_city")]
        public string RefundAccountHolderAddressCity { get; set; }

        [JsonProperty("refund_account_holder_address_country")]
        [STJS.JsonPropertyName("refund_account_holder_address_country")]
        public string RefundAccountHolderAddressCountry { get; set; }

        [JsonProperty("refund_account_holder_address_line1")]
        [STJS.JsonPropertyName("refund_account_holder_address_line1")]
        public string RefundAccountHolderAddressLine1 { get; set; }

        [JsonProperty("refund_account_holder_address_line2")]
        [STJS.JsonPropertyName("refund_account_holder_address_line2")]
        public string RefundAccountHolderAddressLine2 { get; set; }

        [JsonProperty("refund_account_holder_address_postal_code")]
        [STJS.JsonPropertyName("refund_account_holder_address_postal_code")]
        public string RefundAccountHolderAddressPostalCode { get; set; }

        [JsonProperty("refund_account_holder_address_state")]
        [STJS.JsonPropertyName("refund_account_holder_address_state")]
        public string RefundAccountHolderAddressState { get; set; }

        [JsonProperty("refund_account_holder_name")]
        [STJS.JsonPropertyName("refund_account_holder_name")]
        public string RefundAccountHolderName { get; set; }

        [JsonProperty("refund_iban")]
        [STJS.JsonPropertyName("refund_iban")]
        public string RefundIban { get; set; }
    }
}
