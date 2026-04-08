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
        private string transactionType;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Account funding transaction details including sender and beneficiary information.
        /// </summary>
        [JsonProperty("account_funding")]
        [STJS.JsonPropertyName("account_funding")]
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
        /// The type of money services transaction.
        /// </summary>
        [JsonProperty("transaction_type")]
        [STJS.JsonPropertyName("transaction_type")]
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
