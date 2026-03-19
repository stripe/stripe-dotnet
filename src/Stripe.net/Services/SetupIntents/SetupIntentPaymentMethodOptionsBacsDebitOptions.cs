// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentPaymentMethodOptionsBacsDebitOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SetupIntentPaymentMethodOptionsBacsDebitMandateOptionsOptions MandateOptions { get; set; }
    }
}
