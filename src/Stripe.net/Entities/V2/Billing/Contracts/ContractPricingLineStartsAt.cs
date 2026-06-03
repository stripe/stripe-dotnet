// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLineStartsAt : StripeEntity<ContractPricingLineStartsAt>
    {
        /// <summary>
        /// The timestamp when the item starts.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
