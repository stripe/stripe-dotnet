// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// The bank transfer type that can be used for funding. Permitted values include:
        /// <c>jp_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
