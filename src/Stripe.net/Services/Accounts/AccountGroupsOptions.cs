// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountGroupsOptions : INestedOptions, IHasSetTracking
    {
        private string paymentsPricing;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The group the account is in to determine their payments pricing, and null if the account
        /// is on customized pricing. <a
        /// href="https://docs.stripe.com/connect/platform-pricing-tools">See the Platform pricing
        /// tool documentation</a> for details.
        /// </summary>
        [JsonProperty("payments_pricing", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("payments_pricing")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string PaymentsPricing
        {
            get => this.paymentsPricing;
            set
            {
                this.paymentsPricing = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
