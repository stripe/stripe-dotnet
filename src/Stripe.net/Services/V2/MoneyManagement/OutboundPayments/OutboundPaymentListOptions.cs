// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter OutboundPayments by their creation time.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public OutboundPaymentListCreatedOptions Created { get; set; }

        /// <summary>
        /// Only return OutboundPayments sent to this recipient.
        /// </summary>
        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// Closed Enum. Only return OutboundPayments with this status.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public List<string> Status { get; set; }
    }
}
