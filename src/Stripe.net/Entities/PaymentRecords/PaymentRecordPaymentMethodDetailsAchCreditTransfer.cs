// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsAchCreditTransfer : StripeEntity<PaymentRecordPaymentMethodDetailsAchCreditTransfer>
    {
        /// <summary>
        /// Account number to transfer funds to.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// Name of the bank associated with the routing number.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// Routing transit number for the bank account to transfer funds to.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }

        /// <summary>
        /// SWIFT code of the bank associated with the routing number.
        /// </summary>
        [JsonProperty("swift_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swift_code")]
#endif
        public string SwiftCode { get; set; }
    }
}
