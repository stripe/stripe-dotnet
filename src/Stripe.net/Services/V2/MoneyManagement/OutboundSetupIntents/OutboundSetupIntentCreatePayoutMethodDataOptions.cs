// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundSetupIntentCreatePayoutMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// Closed Enum. The type of payout method to be created.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>crypto_wallet</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The type specific details of the bank account payout method.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public OutboundSetupIntentCreatePayoutMethodDataBankAccountOptions BankAccount { get; set; }

        /// <summary>
        /// The type specific details of the card payout method.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public OutboundSetupIntentCreatePayoutMethodDataCardOptions Card { get; set; }
    }
}
