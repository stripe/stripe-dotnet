// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer>
    {
        /// <summary>
        /// The bank transfer type that can be used for funding. Permitted values include:
        /// <c>us_bank_account</c>, <c>eu_bank_account</c>, <c>id_bank_account</c>,
        /// <c>gb_bank_account</c>, <c>jp_bank_account</c>, <c>mx_bank_account</c>,
        /// <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>id_bank_transfer</c>,
        /// <c>jp_bank_transfer</c>, <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
