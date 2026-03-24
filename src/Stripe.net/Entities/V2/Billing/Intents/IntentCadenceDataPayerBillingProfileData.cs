// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentCadenceDataPayerBillingProfileData : StripeEntity<IntentCadenceDataPayerBillingProfileData>
    {
        /// <summary>
        /// The customer to associate with the profile.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The default payment method to use when billing this profile. If none is provided, the
        /// customer <c>default_payment_method</c> will be used.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }
    }
}
