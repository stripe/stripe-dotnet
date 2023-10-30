// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionCancellationDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Additional comments about why the user canceled the subscription, if the subscription
        /// was canceled explicitly by the user.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// The customer submitted reason for why they canceled, if the subscription was canceled
        /// explicitly by the user.
        /// One of: <c>customer_service</c>, <c>low_quality</c>, <c>missing_features</c>,
        /// <c>other</c>, <c>switched_service</c>, <c>too_complex</c>, <c>too_expensive</c>, or
        /// <c>unused</c>.
        /// </summary>
        [JsonProperty("feedback")]
        public string Feedback { get; set; }
    }
}
