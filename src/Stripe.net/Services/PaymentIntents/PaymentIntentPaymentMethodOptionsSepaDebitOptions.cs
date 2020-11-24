// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
        public PaymentIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions MandateOptions { get; set; }
    }
}
