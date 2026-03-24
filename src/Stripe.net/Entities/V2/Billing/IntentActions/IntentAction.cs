// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Billing Intent Action represents a specific operation within a Billing Intent, such as
    /// subscribing to a Pricing Plan, modifying a subscription's quantity, or deactivating
    /// service. Each action has a specific type and associated details that define what change
    /// will be made when the Intent is committed.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentAction : StripeEntity<IntentAction>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
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
        /// Details for an apply action.
        /// </summary>
        [JsonProperty("apply")]
        [STJS.JsonPropertyName("apply")]
        public IntentActionApply Apply { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details for a deactivate action.
        /// </summary>
        [JsonProperty("deactivate")]
        [STJS.JsonPropertyName("deactivate")]
        public IntentActionDeactivate Deactivate { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Details for a modify action.
        /// </summary>
        [JsonProperty("modify")]
        [STJS.JsonPropertyName("modify")]
        public IntentActionModify Modify { get; set; }

        /// <summary>
        /// Details for a remove action.
        /// </summary>
        [JsonProperty("remove")]
        [STJS.JsonPropertyName("remove")]
        public IntentActionRemove Remove { get; set; }

        /// <summary>
        /// Details for a subscribe action.
        /// </summary>
        [JsonProperty("subscribe")]
        [STJS.JsonPropertyName("subscribe")]
        public IntentActionSubscribe Subscribe { get; set; }

        /// <summary>
        /// Type of the Billing Intent Action.
        /// One of: <c>apply</c>, <c>deactivate</c>, <c>modify</c>, <c>remove</c>, or
        /// <c>subscribe</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
