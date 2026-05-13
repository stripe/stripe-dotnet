// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DebitDisputeCreateOptions : BaseOptions
    {
        /// <summary>
        /// Parameters for bank transfer disputes.
        /// </summary>
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public DebitDisputeCreateBankTransferOptions BankTransfer { get; set; }

        /// <summary>
        /// The ID of the ReceivedDebit to dispute.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
