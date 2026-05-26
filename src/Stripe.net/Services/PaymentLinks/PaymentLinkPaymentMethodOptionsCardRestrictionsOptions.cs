// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkPaymentMethodOptionsCardRestrictionsOptions : INestedOptions, IHasSetTracking
    {
        private List<string> brandsBlocked;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The card brands to block. If a customer enters or selects a card belonging to a blocked
        /// brand, they can't complete the payment.
        /// One of: <c>american_express</c>, <c>discover_global_network</c>, <c>mastercard</c>, or
        /// <c>visa</c>.
        /// </summary>
        [JsonProperty("brands_blocked", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("brands_blocked")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> BrandsBlocked
        {
            get => this.brandsBlocked;
            set
            {
                this.brandsBlocked = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
