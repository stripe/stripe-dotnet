// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionCancellationDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Additional comments about why the user canceled the subscription, if the subscription
        /// was cancelled explicitly by the user.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// The customer submitted reason for why they cancelled, if the subscription was cancelled
        /// explicitly by the user.
        /// </summary>
        [JsonProperty("feedback")]
        public string Feedback { get; set; }
    }
}
