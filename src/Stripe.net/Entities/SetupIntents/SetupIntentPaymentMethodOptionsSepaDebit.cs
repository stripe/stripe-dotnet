// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsSepaDebit : StripeEntity<SetupIntentPaymentMethodOptionsSepaDebit>
    {
        [JsonProperty("mandate_options")]
        public SetupIntentPaymentMethodOptionsSepaDebitMandateOptions MandateOptions { get; set; }
    }
}
