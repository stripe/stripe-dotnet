// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsFulfillmentOptionDigital : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOptionDigital>
    {
        /// <summary>
        /// The digital options.
        /// </summary>
        [JsonProperty("digital_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("digital_options")]
#endif
        public List<RequestedSessionFulfillmentDetailsFulfillmentOptionDigitalDigitalOption> DigitalOptions { get; set; }
    }
}
