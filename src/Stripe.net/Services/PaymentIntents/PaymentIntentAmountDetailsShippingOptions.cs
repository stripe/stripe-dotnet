// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsShippingOptions : INestedOptions, IHasSetTracking
    {
        private long? amount;
        private string fromPostalCode;
        private string toPostalCode;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// If a physical good is being shipped, the cost of shipping represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>. An
        /// integer greater than or equal to 0.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("amount")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        /// If a physical good is being shipped, the postal code of where it is being shipped from.
        /// At most 10 alphanumeric characters long, hyphens are allowed.
        /// </summary>
        [JsonProperty("from_postal_code", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("from_postal_code")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string FromPostalCode
        {
            get => this.fromPostalCode;
            set
            {
                this.fromPostalCode = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If a physical good is being shipped, the postal code of where it is being shipped to. At
        /// most 10 alphanumeric characters long, hyphens are allowed.
        /// </summary>
        [JsonProperty("to_postal_code", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("to_postal_code")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ToPostalCode
        {
            get => this.toPostalCode;
            set
            {
                this.toPostalCode = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
