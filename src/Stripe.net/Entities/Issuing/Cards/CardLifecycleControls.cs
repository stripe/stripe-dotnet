// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardLifecycleControls : StripeEntity<CardLifecycleControls>
    {
        [JsonProperty("cancel_after")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancel_after")]
#endif
        public CardLifecycleControlsCancelAfter CancelAfter { get; set; }
    }
}
