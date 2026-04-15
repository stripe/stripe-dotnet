// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentMethodOptionsBizumOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SessionPaymentMethodOptionsBizumMandateOptionsOptions MandateOptions { get; set; }
    }
}
