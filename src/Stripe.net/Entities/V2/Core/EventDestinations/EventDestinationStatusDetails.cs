// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventDestinationStatusDetails : StripeEntity<EventDestinationStatusDetails>
    {
        /// <summary>
        /// Details about why the event destination has been disabled.
        /// </summary>
        [JsonProperty("disabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disabled")]
#endif
        public EventDestinationStatusDetailsDisabled Disabled { get; set; }
    }
}
