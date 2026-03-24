// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentRecipientNotification : StripeEntity<OutboundPaymentRecipientNotification>
    {
        /// <summary>
        /// Closed Enum. Configuration option to enable or disable notifications to recipients. Do
        /// not send notifications when setting is NONE. Default to account setting when setting is
        /// CONFIGURED or not set.
        /// One of: <c>configured</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("setting")]
        [STJS.JsonPropertyName("setting")]
        public string Setting { get; set; }
    }
}
