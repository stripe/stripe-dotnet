// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsMoneyServicesOptions : INestedOptions, IHasSetTracking
    {
        private PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions accountFunding;
        private PaymentIntentPaymentDetailsMoneyServicesBeneficiaryDetailsOptions beneficiaryDetails;
        private string transactionType;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Account funding transaction details including sender information.
        /// </summary>
        [JsonProperty("account_funding", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("account_funding")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions AccountFunding
        {
            get => this.accountFunding;
            set
            {
                this.accountFunding = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// ID of the Account representing the beneficiary in this account funding transaction.
        /// </summary>
        [JsonProperty("beneficiary_account")]
        [STJS.JsonPropertyName("beneficiary_account")]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Inline identity details for the beneficiary of this transaction.
        /// </summary>
        [JsonProperty("beneficiary_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("beneficiary_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentIntentPaymentDetailsMoneyServicesBeneficiaryDetailsOptions BeneficiaryDetails
        {
            get => this.beneficiaryDetails;
            set
            {
                this.beneficiaryDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The type of money services transaction.
        /// One of: <c>account_funding</c>, or <c>debt_repayment</c>.
        /// </summary>
        [JsonProperty("transaction_type", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("transaction_type")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string TransactionType
        {
            get => this.transactionType;
            set
            {
                this.transactionType = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
