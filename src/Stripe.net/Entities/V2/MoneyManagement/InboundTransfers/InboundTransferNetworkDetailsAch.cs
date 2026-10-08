// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferNetworkDetailsAch : StripeEntity<InboundTransferNetworkDetailsAch>
    {
        /// <summary>
        /// Freeform payment-related information from the type-7 ACH addenda record. Echoes the
        /// submitted value.
        /// </summary>
        [JsonProperty("addenda")]
        [STJS.JsonPropertyName("addenda")]
        public string Addenda { get; set; }
    }
}
