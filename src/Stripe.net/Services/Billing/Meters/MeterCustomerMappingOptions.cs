// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterCustomerMappingOptions : INestedOptions
    {
        /// <summary>
        /// The key in the usage event payload to use for mapping the event to a customer.
        /// </summary>
        [JsonProperty("event_payload_key")]
        public string EventPayloadKey { get; set; }

        /// <summary>
        /// The method for mapping a meter event to a customer. Must be <c>by_id</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
