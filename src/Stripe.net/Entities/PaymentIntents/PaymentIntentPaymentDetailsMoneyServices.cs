// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsMoneyServices : StripeEntity<PaymentIntentPaymentDetailsMoneyServices>
    {
        [JsonProperty("account_funding")]
        [STJS.JsonPropertyName("account_funding")]
        public PaymentIntentPaymentDetailsMoneyServicesAccountFunding AccountFunding { get; set; }

        [JsonProperty("beneficiary_account")]
        [STJS.JsonPropertyName("beneficiary_account")]
        public string BeneficiaryAccount { get; set; }

        [JsonProperty("beneficiary_details")]
        [STJS.JsonPropertyName("beneficiary_details")]
        public PaymentIntentPaymentDetailsMoneyServicesBeneficiaryDetails BeneficiaryDetails { get; set; }

        /// <summary>
        /// The type of money services transaction.
        /// One of: <c>account_funding</c>, or <c>debt_repayment</c>.
        /// </summary>
        [JsonProperty("transaction_type")]
        [STJS.JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }
    }
}
