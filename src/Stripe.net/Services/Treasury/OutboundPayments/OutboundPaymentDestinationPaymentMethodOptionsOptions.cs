// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentDestinationPaymentMethodOptionsOptions : INestedOptions, IHasSetTracking
    {
        private OutboundPaymentDestinationPaymentMethodOptionsUsBankAccountOptions usBankAccount;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Optional fields for <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public OutboundPaymentDestinationPaymentMethodOptionsUsBankAccountOptions UsBankAccount
        {
            get => this.usBankAccount;
            set
            {
                this.usBankAccount = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
