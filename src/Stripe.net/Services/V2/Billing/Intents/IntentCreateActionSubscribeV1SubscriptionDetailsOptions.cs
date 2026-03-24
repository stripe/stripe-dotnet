// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionSubscribeV1SubscriptionDetailsOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The subscription’s description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 20 subscription items, each with an attached price.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<IntentCreateActionSubscribeV1SubscriptionDetailsItemOptions> Items { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
