// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodCardNetworksOptions : INestedOptions, IHasSetTracking
    {
        private string preferred;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The customer's preferred card network for co-branded cards. Supports
        /// <c>cartes_bancaires</c>, <c>mastercard</c>, or <c>visa</c>. Selection of a network that
        /// does not apply to the card will be stored as <c>invalid_preference</c> on the card.
        /// One of: <c>cartes_bancaires</c>, <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("preferred")]
        [STJS.JsonPropertyName("preferred")]
        public string Preferred
        {
            get => this.preferred;
            set
            {
                this.preferred = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
