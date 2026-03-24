// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionCancellationDetailsOptions : INestedOptions, IHasSetTracking
    {
        private string comment;
        private string feedback;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Additional comments about why the user canceled the subscription, if the subscription
        /// was canceled explicitly by the user.
        /// </summary>
        [JsonProperty("comment")]
        [STJS.JsonPropertyName("comment")]
        public string Comment
        {
            get => this.comment;
            set
            {
                this.comment = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The customer submitted reason for why they canceled, if the subscription was canceled
        /// explicitly by the user.
        /// One of: <c>customer_service</c>, <c>low_quality</c>, <c>missing_features</c>,
        /// <c>other</c>, <c>switched_service</c>, <c>too_complex</c>, <c>too_expensive</c>, or
        /// <c>unused</c>.
        /// </summary>
        [JsonProperty("feedback")]
        [STJS.JsonPropertyName("feedback")]
        public string Feedback
        {
            get => this.feedback;
            set
            {
                this.feedback = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
