// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitCardSpend : StripeEntity<ReceivedDebitCardSpend>
    {
        /// <summary>
        /// The Issuing Authorization for this card_spend. Contains the reference id and the amount.
        /// </summary>
        [JsonProperty("authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization")]
#endif
        public ReceivedDebitCardSpendAuthorization Authorization { get; set; }

        /// <summary>
        /// The list of card spend transactions. These contain the transaction reference ID and the
        /// amount.
        /// </summary>
        [JsonProperty("card_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_transactions")]
#endif
        public List<ReceivedDebitCardSpendCardTransaction> CardTransactions { get; set; }

        /// <summary>
        /// The reference to the card object that resulted in the debit.
        /// </summary>
        [JsonProperty("card_v1_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_v1_id")]
#endif
        public string CardV1Id { get; set; }
    }
}
