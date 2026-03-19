// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance>
    {
        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// The funding method type to be used when there are not enough funds in the customer
        /// balance. Permitted values include: <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("funding_type")]
        [STJS.JsonPropertyName("funding_type")]
        public string FundingType { get; set; }
    }
}
