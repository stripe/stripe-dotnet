// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsBacsDebitOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
        public SetupIntentPaymentMethodOptionsBacsDebitMandateOptionsOptions MandateOptions { get; set; }
    }
}
