// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormProductRemoval : StripeEntity<FormProductRemoval>
    {
        /// <summary>
        /// Time when the prohibited items were removed, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("items_removed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("items_removed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ItemsRemovedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
