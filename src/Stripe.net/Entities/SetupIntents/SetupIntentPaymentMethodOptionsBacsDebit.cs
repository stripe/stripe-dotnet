// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentPaymentMethodOptionsBacsDebit : StripeEntity<SetupIntentPaymentMethodOptionsBacsDebit>
    {
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SetupIntentPaymentMethodOptionsBacsDebitMandateOptions MandateOptions { get; set; }
    }
}
