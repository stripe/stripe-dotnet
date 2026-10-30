// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A commercial term. Display order is independent of billing evaluation order.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTerm : StripeEntity<ContractTerm>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// The stable ID of the term.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Present when type is ad_hoc_product.
        /// </summary>
        [JsonProperty("ad_hoc_product")]
        [STJS.JsonPropertyName("ad_hoc_product")]
        public ContractTermAdHocProduct AdHocProduct { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The lookup key, unique across all term types on this contract.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs attached to the term.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Present when type is pricing_override.
        /// </summary>
        [JsonProperty("pricing_override")]
        [STJS.JsonPropertyName("pricing_override")]
        public ContractTermPricingOverride PricingOverride { get; set; }

        /// <summary>
        /// Present when type is recurring_price.
        /// </summary>
        [JsonProperty("recurring_price")]
        [STJS.JsonPropertyName("recurring_price")]
        public ContractTermRecurringPrice RecurringPrice { get; set; }

        /// <summary>
        /// The type of this term.
        /// One of: <c>ad_hoc_product</c>, <c>pricing_override</c>, or <c>recurring_price</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
