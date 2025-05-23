// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceMultibanco : StripeEntity<SourceMultibanco>
    {
        [JsonProperty("entity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entity")]
#endif
        public string Entity { get; set; }

        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        [JsonProperty("refund_account_holder_address_city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_address_city")]
#endif
        public string RefundAccountHolderAddressCity { get; set; }

        [JsonProperty("refund_account_holder_address_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_address_country")]
#endif
        public string RefundAccountHolderAddressCountry { get; set; }

        [JsonProperty("refund_account_holder_address_line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_address_line1")]
#endif
        public string RefundAccountHolderAddressLine1 { get; set; }

        [JsonProperty("refund_account_holder_address_line2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_address_line2")]
#endif
        public string RefundAccountHolderAddressLine2 { get; set; }

        [JsonProperty("refund_account_holder_address_postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_address_postal_code")]
#endif
        public string RefundAccountHolderAddressPostalCode { get; set; }

        [JsonProperty("refund_account_holder_address_state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_address_state")]
#endif
        public string RefundAccountHolderAddressState { get; set; }

        [JsonProperty("refund_account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_account_holder_name")]
#endif
        public string RefundAccountHolderName { get; set; }

        [JsonProperty("refund_iban")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_iban")]
#endif
        public string RefundIban { get; set; }
    }
}
