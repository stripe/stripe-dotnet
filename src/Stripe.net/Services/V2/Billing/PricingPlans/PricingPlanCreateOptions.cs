// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PricingPlanCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The currency of the PricingPlan.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Description of pricing plan subscription.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Display name of the PricingPlan. Maximum 250 characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular PricingPlan. Maximum length of
        /// 200 characters.
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

        /// <summary>
        /// The Stripe Tax tax behavior - whether the PricingPlan is inclusive or exclusive of tax.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
