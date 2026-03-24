// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsPayto : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsPayto>
    {
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsPaytoMandateOptions MandateOptions { get; set; }
    }
}
