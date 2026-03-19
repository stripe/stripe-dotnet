// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardLifecycleControlsOptions : INestedOptions
    {
        /// <summary>
        /// Cancels the card after the specified conditions are met.
        /// </summary>
        [JsonProperty("cancel_after")]
        [STJS.JsonPropertyName("cancel_after")]
        public CardLifecycleControlsCancelAfterOptions CancelAfter { get; set; }
    }
}
