// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodDataBacsDebitOptions : INestedOptions
    {
        /// <summary>
        /// Account number of the bank account that the funds will be debited from.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// Sort code of the bank account. (e.g., <c>10-20-30</c>).
        /// </summary>
        [JsonProperty("sort_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sort_code")]
#endif
        public string SortCode { get; set; }
    }
}
