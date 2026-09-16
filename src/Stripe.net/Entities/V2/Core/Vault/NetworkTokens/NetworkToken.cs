// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A NetworkToken object represents a network token provisioned for a card.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class NetworkToken : StripeEntity<NetworkToken>, IHasId, IHasObject
    {
        /// <summary>
        /// ID of the NetworkToken object.
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
        /// This field is unset in create and retrieve responses. It is populated only after a
        /// successful generate_cryptogram request.
        /// </summary>
        [JsonProperty("cryptogram")]
        [STJS.JsonPropertyName("cryptogram")]
        public NetworkTokenCryptogram Cryptogram { get; set; }

        /// <summary>
        /// The month the network token expires.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public string ExpMonth { get; set; }

        /// <summary>
        /// The year the network token expires.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public string ExpYear { get; set; }

        /// <summary>
        /// Whether the object exists in live mode or in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The network token number.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Closed Enum. The status of the network token.
        /// One of: <c>active</c>, <c>deactivated</c>, or <c>suspended</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
