// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsMoneyServicesOptions : INestedOptions, IHasSetTracking
    {
        private ChargePaymentDetailsMoneyServicesAccountFundingOptions accountFunding;
        private string transactionType;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Account funding transaction details including sender and beneficiary information.
        /// </summary>
        [JsonProperty("account_funding", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("account_funding")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ChargePaymentDetailsMoneyServicesAccountFundingOptions AccountFunding
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
