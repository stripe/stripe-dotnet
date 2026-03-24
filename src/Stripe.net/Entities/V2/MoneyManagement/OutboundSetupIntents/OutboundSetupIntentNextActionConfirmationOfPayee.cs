// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundSetupIntentNextActionConfirmationOfPayee : StripeEntity<OutboundSetupIntentNextActionConfirmationOfPayee>, IHasObject
    {
        /// <summary>
        /// The type of the credential.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The Confirmation of Payee status.
        /// One of: <c>awaiting_acknowledgement</c>, <c>confirmed</c>, or <c>uninitiated</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
