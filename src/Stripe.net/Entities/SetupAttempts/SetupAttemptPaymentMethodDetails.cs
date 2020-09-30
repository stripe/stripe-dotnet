// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupAttemptPaymentMethodDetails : StripeEntity<SetupAttemptPaymentMethodDetails>
    {
        [JsonProperty("card")]
        public SetupAttemptPaymentMethodDetailsCard Card { get; set; }

        /// <summary>
        /// The type of the payment method used in the SetupIntent (e.g., <c>card</c>). An
        /// additional hash is included on <c>payment_method_details</c> with a name matching this
        /// value. It contains confirmation-specific information for the payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
