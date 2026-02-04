// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateCadenceDataPayerBillingProfileDataOptions : INestedOptions
    {
        /// <summary>
        /// The customer to associate with the profile.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The default payment method to use when billing this profile. If left blank, the
        /// <c>PaymentMethod</c> from the <c>PaymentIntent</c> provided on commit will be used to
        /// create the profile.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
        public string DefaultPaymentMethod { get; set; }
    }
}
