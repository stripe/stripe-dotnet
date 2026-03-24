// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsSurchargeOptions : INestedOptions, IHasSetTracking
    {
        private long? amount;
        private string enforceValidation;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Portion of the amount that corresponds to a surcharge.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount
        {
            get => this.amount;
            set
            {
                this.amount = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Indicate whether to enforce validations on the surcharge amount.
        /// One of: <c>automatic</c>, <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("enforce_validation")]
        [STJS.JsonPropertyName("enforce_validation")]
        public string EnforceValidation
        {
            get => this.enforceValidation;
            set
            {
                this.enforceValidation = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
