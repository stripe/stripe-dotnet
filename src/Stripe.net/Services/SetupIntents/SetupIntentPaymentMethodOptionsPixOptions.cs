// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodOptionsPixOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif
        public SetupIntentPaymentMethodOptionsPixMandateOptionsOptions MandateOptions { get; set; }
    }
}
