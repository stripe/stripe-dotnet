// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionCreateUnlinkedRefundOptions : BaseOptions
    {
        /// <summary>
        /// The total amount to attempt to refund. This amount is in the provided currency, or
        /// defaults to the cards currency, and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

        /// <summary>
        /// Card associated with this unlinked refund transaction.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif

        public string Card { get; set; }

        /// <summary>
        /// The currency of the unlinked refund. If not provided, defaults to the currency of the
        /// card. Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// Details about the seller (grocery store, e-commerce website, etc.) where the card
        /// authorization happened.
        /// </summary>
        [JsonProperty("merchant_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_data")]
#endif

        public TransactionMerchantDataOptions MerchantData { get; set; }

        /// <summary>
        /// Additional purchase information that is optionally provided by the merchant.
        /// </summary>
        [JsonProperty("purchase_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purchase_details")]
#endif

        public TransactionPurchaseDetailsOptions PurchaseDetails { get; set; }
    }
}
