// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewIdBankTransfer : StripeEntity<ConfirmationTokenPaymentMethodPreviewIdBankTransfer>
    {
        /// <summary>
        /// One of: <c>bca</c>, <c>bni</c>, <c>bri</c>, <c>cimb</c>, or <c>permata</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
