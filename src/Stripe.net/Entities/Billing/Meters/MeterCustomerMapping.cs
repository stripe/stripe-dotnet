// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterCustomerMapping : StripeEntity<MeterCustomerMapping>
    {
        /// <summary>
        /// The key in the usage event payload to use for mapping the event to a customer.
        /// </summary>
        [JsonProperty("event_payload_key")]
        public string EventPayloadKey { get; set; }

        /// <summary>
        /// The method for mapping a meter event to a customer.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
