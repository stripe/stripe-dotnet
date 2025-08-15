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
    public class ProfileUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The ID of the payment method object.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("display_name")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalDisplayName { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyDisplayName
        {
            get => this.InternalDisplayName?.Empty ?? false;
            set
            {
                this.InternalDisplayName ??= new Emptyable<string>();
                this.InternalDisplayName.Empty = value;
            }
        }

        /// <summary>
        /// A customer-facing name for the billing profile. Maximum length of 250 characters. To
        /// remove the display_name from the object, set it to null in the request.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DisplayName
        {
            get => this.InternalDisplayName?.Value;
            set
            {
                this.InternalDisplayName ??= new Emptyable<string>();
                this.InternalDisplayName.Value = value;
            }
        }

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
        /// An internal key you can use to search for a particular billing profile. It must be
        /// unique among billing profiles for a given customer. Maximum length of 200 characters. To
        /// remove the lookup_key from the object, set it to null in the request.
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
    }
}
