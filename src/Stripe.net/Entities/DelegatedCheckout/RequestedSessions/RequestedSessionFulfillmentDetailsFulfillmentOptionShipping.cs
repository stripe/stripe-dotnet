// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionFulfillmentDetailsFulfillmentOptionShipping : StripeEntity<RequestedSessionFulfillmentDetailsFulfillmentOptionShipping>
    {
        /// <summary>
        /// The shipping options.
        /// </summary>
        [JsonProperty("shipping_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_options")]
#endif
        public List<RequestedSessionFulfillmentDetailsFulfillmentOptionShippingShippingOption> ShippingOptions { get; set; }
    }
}
