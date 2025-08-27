// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class CustomPricingUnitUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the Custom Pricing Unit is active.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

        /// <summary>
        /// Description that customers will see in the invoice line item.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        [JsonProperty("lookup_key")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalLookupKey { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyLookupKey
        {
            get => this.InternalLookupKey?.Empty ?? false;
            set
            {
                this.InternalLookupKey ??= new Emptyable<string>();
                this.InternalLookupKey.Empty = value;
            }
        }

        /// <summary>
        /// An internal key you can use to search for a particular CustomPricingUnit item.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string LookupKey
        {
            get => this.InternalLookupKey?.Value;
            set
            {
                this.InternalLookupKey ??= new Emptyable<string>();
                this.InternalLookupKey.Value = value;
            }
        }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }
    }
}
