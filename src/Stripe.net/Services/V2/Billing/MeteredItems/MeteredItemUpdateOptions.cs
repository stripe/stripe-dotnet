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
    public class MeteredItemUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Description that customers will see in the invoice line item. Maximum length of 250
        /// characters.
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
        /// An internal key you can use to search for a particular billable item. Maximum length of
        /// 200 characters. To remove the lookup_key from the object, set it to null in the request.
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
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Stripe Tax details.
        /// </summary>
        [JsonProperty("tax_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_details")]
#endif
        public MeteredItemUpdateTaxDetailsOptions TaxDetails { get; set; }

        [JsonProperty("unit_label")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_label")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalUnitLabel { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyUnitLabel
        {
            get => this.InternalUnitLabel?.Empty ?? false;
            set
            {
                this.InternalUnitLabel ??= new Emptyable<string>();
                this.InternalUnitLabel.Empty = value;
            }
        }

        /// <summary>
        /// The unit to use when displaying prices for this billable item in places like Checkout.
        /// For example, set this field to "CPU-hour" for Checkout to display "(price) per
        /// CPU-hour", or "1 million events" to display "(price) per 1 million events". Maximum
        /// length of 100 characters. To remove the unit_label from the object, set it to null in
        /// the request.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string UnitLabel
        {
            get => this.InternalUnitLabel?.Value;
            set
            {
                this.InternalUnitLabel ??= new Emptyable<string>();
                this.InternalUnitLabel.Value = value;
            }
        }
    }
}
