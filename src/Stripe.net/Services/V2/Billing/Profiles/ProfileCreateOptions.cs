// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProfileCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The ID of the customer object.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the payment method object.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// A customer-facing name for the billing profile. Maximum length of 250 characters.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular billing profile. It must be
        /// unique among billing profiles for a given customer. Maximum length of 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

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
