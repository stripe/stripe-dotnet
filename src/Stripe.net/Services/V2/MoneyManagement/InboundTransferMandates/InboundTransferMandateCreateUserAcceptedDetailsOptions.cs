// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferMandateCreateUserAcceptedDetailsOptions : INestedOptions
    {
        /// <summary>
        /// When the merchant accepted the mandate. Must be a past timestamp. For direct account
        /// requests, defaults to the mandate's creation time when not supplied.
        /// </summary>
        [JsonProperty("accepted_at")]
        [STJS.JsonPropertyName("accepted_at")]
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// Optional details for online acceptance.
        /// </summary>
        [JsonProperty("online")]
        [STJS.JsonPropertyName("online")]
        public InboundTransferMandateCreateUserAcceptedDetailsOnlineOptions Online { get; set; }

        /// <summary>
        /// Channel through which acceptance was obtained.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
