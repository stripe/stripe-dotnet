// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentRecipientNotification : StripeEntity<OutboundPaymentRecipientNotification>
    {
        /// <summary>
        /// Closed Enum. Configuration option to enable or disable notifications to recipients. Do
        /// not send notifications when setting is NONE. Default to account setting when setting is
        /// CONFIGURED or not set.
        /// One of: <c>configured</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("setting")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setting")]
#endif
        public string Setting { get; set; }
    }
}
