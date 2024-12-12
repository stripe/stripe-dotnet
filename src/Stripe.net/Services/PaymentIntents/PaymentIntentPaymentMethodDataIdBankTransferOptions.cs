// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodDataIdBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// Bank where the account is held.
        /// One of: <c>bca</c>, <c>bni</c>, <c>bri</c>, <c>cimb</c>, or <c>permata</c>.
        /// </summary>
        [JsonProperty("bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank")]
#endif
        public string Bank { get; set; }
    }
}
