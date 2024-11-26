// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance>
    {
        [JsonProperty("bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_transfer")]
#endif
        public InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// The funding method type to be used when there are not enough funds in the customer
        /// balance. Permitted values include: <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("funding_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding_type")]
#endif
        public string FundingType { get; set; }
    }
}
