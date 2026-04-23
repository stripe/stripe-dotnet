// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentMethodOptionsBlikMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Date when the mandate expires and no further payments will be charged. If not provided,
        /// the mandate will be set to be indefinite.
        /// </summary>
        [JsonProperty("expires_after")]
        [STJS.JsonPropertyName("expires_after")]
        public long? ExpiresAfter { get; set; }
    }
}
