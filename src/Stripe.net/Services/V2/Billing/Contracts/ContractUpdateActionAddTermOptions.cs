// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionAddTermOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Lookup key unique across all term types on the contract.
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
        /// Required when type is pricing_override.
        /// </summary>
        [JsonProperty("pricing_override")]
        [STJS.JsonPropertyName("pricing_override")]
        public ContractUpdateActionAddTermPricingOverrideOptions PricingOverride { get; set; }

        /// <summary>
        /// Required when type is recurring_price.
        /// </summary>
        [JsonProperty("recurring_price")]
        [STJS.JsonPropertyName("recurring_price")]
        public ContractUpdateActionAddTermRecurringPriceOptions RecurringPrice { get; set; }

        /// <summary>
        /// Required when type is scheduled_fee.
        /// </summary>
        [JsonProperty("scheduled_fee")]
        [STJS.JsonPropertyName("scheduled_fee")]
        public ContractUpdateActionAddTermScheduledFeeOptions ScheduledFee { get; set; }

        /// <summary>
        /// The term type. Production types require exactly one matching payload.
        /// One of: <c>pricing_override</c>, <c>recurring_price</c>, or <c>scheduled_fee</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
