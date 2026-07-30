// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InquiryProductRemoval : StripeEntity<InquiryProductRemoval>
    {
        /// <summary>
        /// The timestamp when the prohibited items were removed.
        /// </summary>
        [JsonProperty("items_removed_at")]
        [STJS.JsonPropertyName("items_removed_at")]
        public DateTime ItemsRemovedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
