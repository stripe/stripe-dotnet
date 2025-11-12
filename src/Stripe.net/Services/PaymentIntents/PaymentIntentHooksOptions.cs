// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentHooksOptions : INestedOptions
    {
        /// <summary>
        /// Arguments passed in automations.
        /// </summary>
        [JsonProperty("inputs")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inputs")]
#endif
        public PaymentIntentHooksInputsOptions Inputs { get; set; }
    }
}
