// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentSetupDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Benefit details for this SetupIntent.
        /// </summary>
        [JsonProperty("benefit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("benefit")]
#endif
        public SetupIntentSetupDetailsBenefitOptions Benefit { get; set; }
    }
}
