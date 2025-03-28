// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundSetupIntentNextActionConfirmationOfPayee : StripeEntity<OutboundSetupIntentNextActionConfirmationOfPayee>, IHasObject
    {
        /// <summary>
        /// The type of the credential.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The Confirmation of Payee status.
        /// One of: <c>awaiting_acknowledgement</c>, <c>confirmed</c>, or <c>uninitiated</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
