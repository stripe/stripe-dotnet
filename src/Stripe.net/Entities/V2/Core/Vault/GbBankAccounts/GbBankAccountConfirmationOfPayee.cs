// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GbBankAccountConfirmationOfPayee : StripeEntity<GbBankAccountConfirmationOfPayee>
    {
        /// <summary>
        /// The result of the Confirmation of Payee check, once the check has been initiated. Closed
        /// enum.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public GbBankAccountConfirmationOfPayeeResult Result { get; set; }

        /// <summary>
        /// The current state of Confirmation of Payee on this bank account. Closed enum.
        /// One of: <c>awaiting_acknowledgement</c>, <c>confirmed</c>, or <c>uninitiated</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
