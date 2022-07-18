// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsBlik : StripeEntity<SetupIntentPaymentMethodOptionsBlik>
    {
        [JsonProperty("mandate_options")]
        public SetupIntentPaymentMethodOptionsBlikMandateOptions MandateOptions { get; set; }
    }
}
