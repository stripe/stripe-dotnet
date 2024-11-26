// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer>
    {
        [JsonProperty("eu_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eu_bank_transfer")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer EuBankTransfer { get; set; }

        /// <summary>
        /// The bank transfer type that can be used for funding. Permitted values include:
        /// <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>,
        /// <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
