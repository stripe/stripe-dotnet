// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferCreateNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// Optional freeform payment-related information written into the type-7 ACH addenda record
        /// of the NACHA submission. Max 80 characters.
        /// </summary>
        [JsonProperty("addenda")]
        [STJS.JsonPropertyName("addenda")]
        public string Addenda { get; set; }
    }
}
