// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentPaymentMethodOptionsPayto : StripeEntity<SetupIntentPaymentMethodOptionsPayto>
    {
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SetupIntentPaymentMethodOptionsPaytoMandateOptions MandateOptions { get; set; }
    }
}
