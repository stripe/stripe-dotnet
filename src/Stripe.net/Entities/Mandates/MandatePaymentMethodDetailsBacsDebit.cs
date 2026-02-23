// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MandatePaymentMethodDetailsBacsDebit : StripeEntity<MandatePaymentMethodDetailsBacsDebit>
    {
        /// <summary>
        /// The display name for the account on this mandate.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The status of the mandate on the Bacs network. Can be one of <c>pending</c>,
        /// <c>revoked</c>, <c>refused</c>, or <c>accepted</c>.
        /// One of: <c>accepted</c>, <c>pending</c>, <c>refused</c>, or <c>revoked</c>.
        /// </summary>
        [JsonProperty("network_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_status")]
#endif
        public string NetworkStatus { get; set; }

        /// <summary>
        /// The unique reference identifying the mandate on the Bacs network.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        /// <summary>
        /// When the mandate is revoked on the Bacs network this field displays the reason for the
        /// revocation.
        /// One of: <c>account_closed</c>, <c>bank_account_restricted</c>,
        /// <c>bank_ownership_changed</c>, <c>could_not_process</c>, or <c>debit_not_authorized</c>.
        /// </summary>
        [JsonProperty("revocation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revocation_reason")]
#endif
        public string RevocationReason { get; set; }

        /// <summary>
        /// The service user number for the account on this mandate.
        /// </summary>
        [JsonProperty("service_user_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_user_number")]
#endif
        public string ServiceUserNumber { get; set; }

        /// <summary>
        /// The URL that will contain the mandate that the customer has signed.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
