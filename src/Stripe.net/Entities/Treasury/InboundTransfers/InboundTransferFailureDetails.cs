// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferFailureDetails : StripeEntity<InboundTransferFailureDetails>
    {
        /// <summary>
        /// Reason for the failure.
        /// One of: <c>account_closed</c>, <c>account_frozen</c>, <c>bank_account_restricted</c>,
        /// <c>bank_ownership_changed</c>, <c>debit_not_authorized</c>,
        /// <c>incorrect_account_holder_address</c>, <c>incorrect_account_holder_name</c>,
        /// <c>incorrect_account_holder_tax_id</c>, <c>insufficient_funds</c>,
        /// <c>invalid_account_number</c>, <c>invalid_currency</c>, <c>no_account</c>, or
        /// <c>other</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }
    }
}
