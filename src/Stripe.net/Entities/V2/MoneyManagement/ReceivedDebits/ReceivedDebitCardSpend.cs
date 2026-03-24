// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitCardSpend : StripeEntity<ReceivedDebitCardSpend>
    {
        /// <summary>
        /// The Issuing Authorization for this card_spend. Contains the reference id and the amount.
        /// </summary>
        [JsonProperty("authorization")]
        [STJS.JsonPropertyName("authorization")]
        public ReceivedDebitCardSpendAuthorization Authorization { get; set; }

        /// <summary>
        /// The list of card spend transactions. These contain the transaction reference ID and the
        /// amount.
        /// </summary>
        [JsonProperty("card_transactions")]
        [STJS.JsonPropertyName("card_transactions")]
        public List<ReceivedDebitCardSpendCardTransaction> CardTransactions { get; set; }

        /// <summary>
        /// The reference to the card object that resulted in the debit.
        /// </summary>
        [JsonProperty("card_v1_id")]
        [STJS.JsonPropertyName("card_v1_id")]
        public string CardV1Id { get; set; }
    }
}
