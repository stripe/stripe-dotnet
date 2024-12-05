// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodOptions : StripeEntity<ConfirmationTokenPaymentMethodOptions>
    {
        /// <summary>
        /// This hash contains the card payment method options.
        /// </summary>
        [JsonProperty("card")]
        public ConfirmationTokenPaymentMethodOptionsCard Card { get; set; }
    }
}
