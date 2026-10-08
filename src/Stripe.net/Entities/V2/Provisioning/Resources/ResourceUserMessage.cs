// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ResourceUserMessage : StripeEntity<ResourceUserMessage>
    {
        /// <summary>
        /// Message from the provider to display to the user.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Time at which Stripe received the message from the provider.
        /// </summary>
        [JsonProperty("received_at")]
        [STJS.JsonPropertyName("received_at")]
        public DateTime ReceivedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
