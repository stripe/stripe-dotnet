// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionSettlementDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Positive settlement amount magnitude in the smallest currency unit. Must match the
        /// converted merchant amount and, when settlement and cardholder currencies are the same,
        /// this capture's finalized transaction amount magnitude. The transaction type determines
        /// the output sign.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Settlement currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Exchange rate from merchant amount to settlement amount, expressed in minor units. Must
        /// be finite and positive for different currencies. Matching currencies ignore the supplied
        /// numeric rate and use 1.0.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public decimal? ExchangeRate { get; set; }
    }
}
