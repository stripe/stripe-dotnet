// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsBacsDebit : StripeEntity<SetupIntentPaymentMethodOptionsBacsDebit>
    {
        [JsonProperty("mandate_options")]
        public SetupIntentPaymentMethodOptionsBacsDebitMandateOptions MandateOptions { get; set; }
    }
}
