// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentItemOneTimePrice : StripeEntity<OffSessionPaymentItemOneTimePrice>, IHasMetadata
    {
        /// <summary>
        /// A description of this item group. Currently always null.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The resolved price IDs and quantities in their original order.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<OffSessionPaymentItemOneTimePriceItem> Items { get; set; }

        /// <summary>
        /// Additional information about this item group. Currently always null.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
