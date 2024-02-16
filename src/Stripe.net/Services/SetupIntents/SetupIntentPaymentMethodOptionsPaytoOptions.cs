// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsPaytoOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
        public SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions MandateOptions { get; set; }
    }
}
