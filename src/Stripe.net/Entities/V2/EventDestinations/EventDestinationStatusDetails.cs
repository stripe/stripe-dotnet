// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class EventDestinationStatusDetails : StripeEntity<EventDestinationStatusDetails>
    {
        /// <summary>
        /// Details about why the event destination has been disabled.
        /// </summary>
        [JsonProperty("disabled")]
        public EventDestinationStatusDetailsDisabled Disabled { get; set; }
    }
}
