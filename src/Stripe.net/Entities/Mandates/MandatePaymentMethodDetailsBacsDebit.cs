// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsBacsDebit : StripeEntity<MandatePaymentMethodDetailsBacsDebit>
    {
        /// <summary>
        /// The status of the mandate on the Bacs network. Can be one of <c>pending</c>,
        /// <c>revoked</c>, <c>refused</c>, or <c>accepted</c>.
        /// One of: <c>accepted</c>, <c>pending</c>, <c>refused</c>, or <c>revoked</c>.
        /// </summary>
        [JsonProperty("network_status")]
        public string NetworkStatus { get; set; }

        /// <summary>
        /// The unique reference identifying the mandate on the Bacs network.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// When the mandate is revoked on the Bacs network this field displays the reason for the
        /// revocation.
        /// One of: <c>account_closed</c>, <c>bank_account_restricted</c>,
        /// <c>bank_ownership_changed</c>, <c>could_not_process</c>, or <c>debit_not_authorized</c>.
        /// </summary>
        [JsonProperty("revocation_reason")]
        public string RevocationReason { get; set; }

        /// <summary>
        /// The URL that will contain the mandate that the customer has signed.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
