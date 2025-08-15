// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CollectionSettingPaymentMethodOptionsCustomerBalance : StripeEntity<CollectionSettingPaymentMethodOptionsCustomerBalance>
    {
        /// <summary>
        /// Configuration for the bank transfer funding type, if the <c>funding_type</c> is set to
        /// <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_transfer")]
#endif
        public CollectionSettingPaymentMethodOptionsCustomerBalanceBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// The funding method type to be used when there are not enough funds in the customer
        /// balance. Currently the only supported value is <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("funding_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding_type")]
#endif
        public string FundingType { get; set; }
    }
}
