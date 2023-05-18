// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsBlikOptions : INestedOptions
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
        public SetupIntentPaymentMethodOptionsBlikMandateOptionsOptions MandateOptions { get; set; }
    }
}
