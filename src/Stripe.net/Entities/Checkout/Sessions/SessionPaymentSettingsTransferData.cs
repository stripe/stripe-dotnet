// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPaymentSettingsTransferData : StripeEntity<SessionPaymentSettingsTransferData>
    {
        /// <summary>
        /// The connected account that receives funds from payments created by this Checkout
        /// Session.
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Configures the amount transferred to the destination account.
        /// </summary>
        [JsonProperty("transfer_amount")]
        [STJS.JsonPropertyName("transfer_amount")]
        public SessionPaymentSettingsTransferDataTransferAmount TransferAmount { get; set; }
    }
}
