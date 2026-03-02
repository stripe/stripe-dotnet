// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// The desired country code of the bank account information. Permitted values include:
        /// <c>DE</c>, <c>FR</c>, <c>IE</c>, or <c>NL</c>.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }
    }
}
