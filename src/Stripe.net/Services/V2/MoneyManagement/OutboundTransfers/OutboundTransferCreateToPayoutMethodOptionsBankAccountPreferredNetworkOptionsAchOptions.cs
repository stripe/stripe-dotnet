// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferCreateToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAchOptions : INestedOptions
    {
        /// <summary>
        /// Freeform ACH addenda (max 80 characters) included in the NACHA submission.
        /// </summary>
        [JsonProperty("addenda")]
        [STJS.JsonPropertyName("addenda")]
        public string Addenda { get; set; }
    }
}
