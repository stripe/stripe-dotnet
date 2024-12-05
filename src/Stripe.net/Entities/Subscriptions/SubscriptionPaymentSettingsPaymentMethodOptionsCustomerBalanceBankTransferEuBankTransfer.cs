// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer>
    {
        /// <summary>
        /// The desired country code of the bank account information. Permitted values include:
        /// <c>BE</c>, <c>DE</c>, <c>ES</c>, <c>FR</c>, <c>IE</c>, or <c>NL</c>.
        /// One of: <c>BE</c>, <c>DE</c>, <c>ES</c>, <c>FR</c>, <c>IE</c>, or <c>NL</c>.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
