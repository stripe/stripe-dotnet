// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Use the OutboundSetupIntent API to create and setup usable payout methods.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundSetupIntent : StripeEntity<OutboundSetupIntent>, IHasId, IHasObject
    {
        /// <summary>
        /// ID of the outbound setup intent.
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
        /// Created timestamp.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Specifies which actions needs to be taken next to continue setup of the credential.
        /// </summary>
        [JsonProperty("next_action")]
        [STJS.JsonPropertyName("next_action")]
        public OutboundSetupIntentNextAction NextAction { get; set; }

        /// <summary>
        /// Use the PayoutMethods API to list and interact with PayoutMethod objects.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public PayoutMethod PayoutMethod { get; set; }

        /// <summary>
        /// Closed Enum. Status of the outbound setup intent.
        /// One of: <c>canceled</c>, <c>requires_action</c>, <c>requires_payout_method</c>, or
        /// <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The intended money movement flow this payout method should be set up for, specified in
        /// params.
        /// One of: <c>payment</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("usage_intent")]
        [STJS.JsonPropertyName("usage_intent")]
        public string UsageIntent { get; set; }
    }
}
