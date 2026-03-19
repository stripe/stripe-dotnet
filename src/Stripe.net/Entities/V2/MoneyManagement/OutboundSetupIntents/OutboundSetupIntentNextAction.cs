// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundSetupIntentNextAction : StripeEntity<OutboundSetupIntentNextAction>
    {
        /// <summary>
        /// The type of next action.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Confirmation of Payee details.
        /// </summary>
        [JsonProperty("confirmation_of_payee")]
        [STJS.JsonPropertyName("confirmation_of_payee")]
        public OutboundSetupIntentNextActionConfirmationOfPayee ConfirmationOfPayee { get; set; }
    }
}
