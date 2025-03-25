// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GbBankAccountConfirmationOfPayee : StripeEntity<GbBankAccountConfirmationOfPayee>
    {
        /// <summary>
        /// The result of the Confirmation of Payee check, once the check has been initiated. Closed
        /// enum.
        /// </summary>
        [JsonProperty("result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result")]
#endif
        public GbBankAccountConfirmationOfPayeeResult Result { get; set; }

        /// <summary>
        /// The current state of Confirmation of Payee on this bank account. Closed enum.
        /// One of: <c>awaiting_acknowledgement</c>, <c>confirmed</c>, or <c>uninitiated</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
