// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundSetupIntentNextAction : StripeEntity<OutboundSetupIntentNextAction>
    {
        /// <summary>
        /// The type of next action.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Confirmation of Payee details.
        /// </summary>
        [JsonProperty("confirmation_of_payee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmation_of_payee")]
#endif
        public OutboundSetupIntentNextActionConfirmationOfPayee ConfirmationOfPayee { get; set; }
    }
}
