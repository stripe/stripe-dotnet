// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodKlarna : StripeEntity<PaymentMethodKlarna>
    {
        /// <summary>
        /// The customer's date of birth, if provided.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public PaymentMethodKlarnaDob Dob { get; set; }
    }
}
