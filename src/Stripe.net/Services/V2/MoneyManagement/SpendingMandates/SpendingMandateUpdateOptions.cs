// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SpendingMandateUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Bank transfer fields to update. Omitted fields remain unchanged.
        /// </summary>
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public SpendingMandateUpdateBankTransferOptions BankTransfer { get; set; }
    }
}
