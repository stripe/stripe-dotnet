// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormProductRemovalOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp when the prohibited items were removed.
        /// </summary>
        [JsonProperty("items_removed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("items_removed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ItemsRemovedAt { get; set; }
    }
}
