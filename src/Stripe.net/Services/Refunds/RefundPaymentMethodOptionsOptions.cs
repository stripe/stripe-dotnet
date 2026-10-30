// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RefundPaymentMethodOptionsOptions : INestedOptions, IHasSetTracking
    {
        private RefundPaymentMethodOptionsGiftCardOptions giftCard;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Gift card refund options.
        /// </summary>
        [JsonProperty("gift_card", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("gift_card")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public RefundPaymentMethodOptionsGiftCardOptions GiftCard
        {
            get => this.giftCard;
            set
            {
                this.giftCard = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
