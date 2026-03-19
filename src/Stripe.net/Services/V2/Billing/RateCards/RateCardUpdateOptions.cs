// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RateCardUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Sets whether the RateCard is active. Inactive RateCards cannot be used in new
        /// activations or have new rates added.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A customer-facing name for the RateCard. This name is used in Stripe-hosted products
        /// like the Customer Portal and Checkout. It does not show up on Invoices. Maximum length
        /// of 250 characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Changes the version that new RateCard activations will use. Providing <c>live_version =
        /// "latest"</c> will set the RateCard's <c>live_version</c> to its latest version.
        /// </summary>
        [JsonProperty("live_version")]
        [STJS.JsonPropertyName("live_version")]
        public string LiveVersion { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular RateCard. Maximum length of 200
        /// characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
