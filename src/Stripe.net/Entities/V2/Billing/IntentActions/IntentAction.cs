// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentAction : StripeEntity<IntentAction>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Details for an apply action.
        /// </summary>
        [JsonProperty("apply")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apply")]
#endif
        public IntentActionApply Apply { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details for a deactivate action.
        /// </summary>
        [JsonProperty("deactivate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deactivate")]
#endif
        public IntentActionDeactivate Deactivate { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Details for a modify action.
        /// </summary>
        [JsonProperty("modify")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("modify")]
#endif
        public IntentActionModify Modify { get; set; }

        /// <summary>
        /// Details for a remove action.
        /// </summary>
        [JsonProperty("remove")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remove")]
#endif
        public IntentActionRemove Remove { get; set; }

        /// <summary>
        /// Details for a subscribe action.
        /// </summary>
        [JsonProperty("subscribe")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscribe")]
#endif
        public IntentActionSubscribe Subscribe { get; set; }

        /// <summary>
        /// Type of the Billing Intent Action.
        /// One of: <c>apply</c>, <c>deactivate</c>, <c>modify</c>, <c>remove</c>, or
        /// <c>subscribe</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
