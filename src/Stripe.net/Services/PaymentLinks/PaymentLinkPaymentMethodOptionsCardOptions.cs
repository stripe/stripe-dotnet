// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkPaymentMethodOptionsCardOptions : INestedOptions, IHasSetTracking
    {
        private PaymentLinkPaymentMethodOptionsCardRestrictionsOptions restrictions;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Restrictions to apply to the card payment method. For example, you can block specific
        /// card brands.
        /// </summary>
        [JsonProperty("restrictions", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("restrictions")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentLinkPaymentMethodOptionsCardRestrictionsOptions Restrictions
        {
            get => this.restrictions;
            set
            {
                this.restrictions = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
