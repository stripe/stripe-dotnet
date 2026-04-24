// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateCadenceDataPayerBillingProfileDataOptions : INestedOptions
    {
        /// <summary>
        /// The customer to associate with the profile.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The default payment method to use when billing this profile. If left blank, the
        /// <c>PaymentMethod</c> from the <c>PaymentIntent</c> provided on commit is used to create
        /// the profile.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }
    }
}
