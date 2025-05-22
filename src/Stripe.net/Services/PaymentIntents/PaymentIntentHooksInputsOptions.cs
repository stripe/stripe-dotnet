// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentHooksInputsOptions : INestedOptions
    {
        /// <summary>
        /// Tax arguments for automations.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public PaymentIntentHooksInputsTaxOptions Tax { get; set; }
    }
}
