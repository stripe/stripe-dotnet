// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Use the OutboundSetupIntent API to create and setup usable payout methods.
    /// </summary>
    public class OutboundSetupIntent : StripeEntity<OutboundSetupIntent>, IHasId, IHasObject
    {
        /// <summary>
        /// ID of the outbound setup intent.
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
        /// Created timestamp.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// Specifies which actions needs to be taken next to continue setup of the credential.
        /// </summary>
        [JsonProperty("next_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_action")]
#endif
        public OutboundSetupIntentNextAction NextAction { get; set; }

        /// <summary>
        /// Information about the payout method that’s created and linked to this outbound setup
        /// intent.
        /// </summary>
        [JsonProperty("payout_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout_method")]
#endif
        public PayoutMethod PayoutMethod { get; set; }

        /// <summary>
        /// Closed Enum. Status of the outbound setup intent.
        /// One of: <c>canceled</c>, <c>requires_action</c>, <c>requires_payout_method</c>, or
        /// <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The intended money movement flow this payout method should be set up for, specified in
        /// params.
        /// One of: <c>payment</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("usage_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_intent")]
#endif
        public string UsageIntent { get; set; }
    }
}
