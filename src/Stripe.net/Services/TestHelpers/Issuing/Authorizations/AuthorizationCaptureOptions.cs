// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationCaptureOptions : BaseOptions
    {
        /// <summary>
        /// The amount to capture from the authorization. If not provided, the full amount of the
        /// authorization will be captured. This amount is in the authorization currency and in the
        /// <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("capture_amount")]
        [STJS.JsonPropertyName("capture_amount")]
        public long? CaptureAmount { get; set; }

        /// <summary>
        /// Whether to close the authorization after capture. Defaults to true. Set to false to
        /// enable multi-capture flows.
        /// </summary>
        [JsonProperty("close_authorization")]
        [STJS.JsonPropertyName("close_authorization")]
        public bool? CloseAuthorization { get; set; }

        /// <summary>
        /// Exchange rate from merchant amount to capture amount, expressed in minor units. Must be
        /// finite and positive for different currencies. Matching currencies ignore the supplied
        /// numeric rate and use 1.0. The capture amount remains authoritative.
        /// </summary>
        [JsonProperty("merchant_amount_exchange_rate")]
        [STJS.JsonPropertyName("merchant_amount_exchange_rate")]
        public decimal? MerchantAmountExchangeRate { get; set; }

        /// <summary>
        /// Details about the transaction, such as processing dates, set by the card network.
        /// </summary>
        [JsonProperty("network_data")]
        [STJS.JsonPropertyName("network_data")]
        public AuthorizationNetworkDataOptions NetworkData { get; set; }

        /// <summary>
        /// Additional purchase information that is optionally provided by the merchant.
        /// </summary>
        [JsonProperty("purchase_details")]
        [STJS.JsonPropertyName("purchase_details")]
        public AuthorizationPurchaseDetailsOptions PurchaseDetails { get; set; }

        /// <summary>
        /// Synthetic settlement values for this purchase capture. If omitted, defaults to the final
        /// signed transaction amount, transaction currency, and effective merchant-to-cardholder
        /// exchange rate. Supply all three fields to override. This does not create a settlement or
        /// change funding.
        /// </summary>
        [JsonProperty("settlement_details")]
        [STJS.JsonPropertyName("settlement_details")]
        public AuthorizationSettlementDetailsOptions SettlementDetails { get; set; }
    }
}
