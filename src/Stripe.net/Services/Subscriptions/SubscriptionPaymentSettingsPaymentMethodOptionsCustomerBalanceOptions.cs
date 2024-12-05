// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the bank transfer funding type, if the <c>funding_type</c> is set to
        /// <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("bank_transfer")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOptions BankTransfer { get; set; }

        /// <summary>
        /// The funding method type to be used when there are not enough funds in the customer
        /// balance. Permitted values include: <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("funding_type")]
        public string FundingType { get; set; }
    }
}
