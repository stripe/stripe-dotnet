// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenPaymentMethodDetailsKlarna : StripeEntity<GrantedTokenPaymentMethodDetailsKlarna>
    {
        /// <summary>
        /// The customer's date of birth, if provided.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public GrantedTokenPaymentMethodDetailsKlarnaDob Dob { get; set; }
    }
}
