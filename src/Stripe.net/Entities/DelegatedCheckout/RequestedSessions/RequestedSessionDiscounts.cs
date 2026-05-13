// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionDiscounts : StripeEntity<RequestedSessionDiscounts>
    {
        /// <summary>
        /// The list of successfully applied discounts.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public List<RequestedSessionDiscountsApplied> Applied { get; set; }

        /// <summary>
        /// The list of discount codes that could not be applied.
        /// </summary>
        [JsonProperty("invalid")]
        [STJS.JsonPropertyName("invalid")]
        public List<RequestedSessionDiscountsInvalid> Invalid { get; set; }
    }
}
