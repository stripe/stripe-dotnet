// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodKlarna : StripeEntity<PaymentMethodKlarna>
    {
        /// <summary>
        /// The customer's date of birth, if provided.
        /// </summary>
        [JsonProperty("dob")]
        public PaymentMethodKlarnaDob Dob { get; set; }
    }
}
