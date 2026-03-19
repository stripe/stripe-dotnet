// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodPreviewKlarna : StripeEntity<ConfirmationTokenPaymentMethodPreviewKlarna>
    {
        /// <summary>
        /// The customer's date of birth, if provided.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public ConfirmationTokenPaymentMethodPreviewKlarnaDob Dob { get; set; }
    }
}
