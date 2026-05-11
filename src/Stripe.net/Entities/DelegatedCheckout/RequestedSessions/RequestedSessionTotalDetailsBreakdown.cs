// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionTotalDetailsBreakdown : StripeEntity<RequestedSessionTotalDetailsBreakdown>
    {
        /// <summary>
        /// The breakdown of discounts applied to the session.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<RequestedSessionTotalDetailsBreakdownDiscount> Discounts { get; set; }
    }
}
