// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewKlarna : StripeEntity<ConfirmationTokenPaymentMethodPreviewKlarna>
    {
        /// <summary>
        /// The customer's date of birth, if provided.
        /// </summary>
        [JsonProperty("dob")]
        public ConfirmationTokenPaymentMethodPreviewKlarnaDob Dob { get; set; }
    }
}
