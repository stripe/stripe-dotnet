// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetailsFulfillmentOptionShipping : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOptionShipping>
    {
        /// <summary>
        /// The shipping options.
        /// </summary>
        [JsonProperty("shipping_options")]
        [STJS.JsonPropertyName("shipping_options")]
        public List<RequestedSessionFulfillmentDetailsFulfillmentOptionShippingShippingOption> ShippingOptions { get; set; }
    }
}
