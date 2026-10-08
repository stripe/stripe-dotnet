// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentSettingsTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// If specified, successful charges will be attributed to the destination account for tax
        /// reporting, and the funds from charges will be transferred to the destination account.
        /// The ID of the resulting transfer will be returned on the successful charge's
        /// <c>transfer</c> field.
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Configures how much of each payment is transferred to the destination account. If
        /// omitted, the entire amount is transferred.
        /// </summary>
        [JsonProperty("transfer_amount")]
        [STJS.JsonPropertyName("transfer_amount")]
        public SessionPaymentSettingsTransferDataTransferAmountOptions TransferAmount { get; set; }
    }
}
