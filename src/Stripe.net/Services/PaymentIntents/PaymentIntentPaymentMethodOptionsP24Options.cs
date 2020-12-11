// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsP24Options : INestedOptions
    {
        /// <summary>
        /// Confirm that the payer has accepted the P24 terms and conditions.
        /// </summary>
        [JsonProperty("tos_shown_and_accepted")]
        public bool? TosShownAndAccepted { get; set; }
    }
}
