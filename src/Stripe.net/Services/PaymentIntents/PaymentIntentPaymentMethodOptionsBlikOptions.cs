// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsBlikOptions : INestedOptions
    {
        /// <summary>
        /// The 6-digit BLIK code that a customer has generated using their banking application. Can
        /// only be set on confirmation.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Details of the BLIK mandate.
        /// </summary>
        [JsonProperty("mandate_options")]
        public PaymentIntentPaymentMethodOptionsBlikMandateOptionsOptions MandateOptions { get; set; }
    }
}
