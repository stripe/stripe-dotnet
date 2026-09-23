// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditBankTransferNetworkDetails : StripeEntity<ReceivedCreditBankTransferNetworkDetails>
    {
        /// <summary>
        /// NACHA details for the ACH entry that created this ReceivedCredit.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public ReceivedCreditBankTransferNetworkDetailsAch Ach { get; set; }
    }
}
