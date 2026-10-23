// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemSubscriptionItemCurrentTrialOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the <a
        /// href="https://docs.stripe.com/api/product-catalog/trial-offer?api-version=2026-03-25.preview">Trial
        /// Offer</a>.
        /// </summary>
        [JsonProperty("trial_offer")]
        [STJS.JsonPropertyName("trial_offer")]
        public string TrialOffer { get; set; }
    }
}
