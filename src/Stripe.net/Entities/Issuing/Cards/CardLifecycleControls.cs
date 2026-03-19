// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardLifecycleControls : StripeEntity<CardLifecycleControls>
    {
        [JsonProperty("cancel_after")]
        [STJS.JsonPropertyName("cancel_after")]
        public CardLifecycleControlsCancelAfter CancelAfter { get; set; }
    }
}
