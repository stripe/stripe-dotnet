// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetailsFulfillmentOptionDigital : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOptionDigital>
    {
        /// <summary>
        /// The digital options.
        /// </summary>
        [JsonProperty("digital_options")]
        [STJS.JsonPropertyName("digital_options")]
        public List<RequestedSessionFulfillmentDetailsFulfillmentOptionDigitalDigitalOption> DigitalOptions { get; set; }
    }
}
