// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBlikOptions : INestedOptions
    {
        /// <summary>
        /// Configuration options for setting up a mandate.
        /// </summary>
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptionsOptions MandateOptions { get; set; }
    }
}
