// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMultibanco : StripeEntity<SourceMultibanco>
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("refund_account_holder_address_city")]
        public string RefundAccountHolderAddressCity { get; set; }

        [JsonProperty("refund_account_holder_address_country")]
        public string RefundAccountHolderAddressCountry { get; set; }

        [JsonProperty("refund_account_holder_address_line1")]
        public string RefundAccountHolderAddressLine1 { get; set; }

        [JsonProperty("refund_account_holder_address_line2")]
        public string RefundAccountHolderAddressLine2 { get; set; }

        [JsonProperty("refund_account_holder_address_postal_code")]
        public string RefundAccountHolderAddressPostalCode { get; set; }

        [JsonProperty("refund_account_holder_address_state")]
        public string RefundAccountHolderAddressState { get; set; }

        [JsonProperty("refund_account_holder_name")]
        public string RefundAccountHolderName { get; set; }

        [JsonProperty("refund_iban")]
        public string RefundIban { get; set; }
    }
}
