// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsPayto : StripeEntity<SetupIntentPaymentMethodOptionsPayto>
    {
        [JsonProperty("mandate_options")]
        public SetupIntentPaymentMethodOptionsPaytoMandateOptions MandateOptions { get; set; }
    }
}
