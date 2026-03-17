// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardLifecycleControlsOptions : INestedOptions
    {
        /// <summary>
        /// Cancels the card after the specified conditions are met.
        /// </summary>
        [JsonProperty("cancel_after")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancel_after")]
#endif
        public CardLifecycleControlsCancelAfterOptions CancelAfter { get; set; }
    }
}
