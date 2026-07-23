// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionConfirmOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Affiliate attribution data associated with this requested session.
        /// </summary>
        [JsonProperty("affiliate_attribution")]
        [STJS.JsonPropertyName("affiliate_attribution")]
        public RequestedSessionAffiliateAttributionOptions AffiliateAttribution { get; set; }

        /// <summary>
        /// The buyer's consent choices for marketing communications.
        /// </summary>
        [JsonProperty("buyer_consents")]
        [STJS.JsonPropertyName("buyer_consents")]
        public RequestedSessionBuyerConsentsOptions BuyerConsents { get; set; }

        /// <summary>
        /// The metadata for this requested session.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The PaymentMethod to use with the requested session.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or complete a payment
        /// action. Required for redirect-based payment methods such as Affirm or Klarna.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Risk details/signals associated with the requested session.
        /// </summary>
        [JsonProperty("risk_details")]
        [STJS.JsonPropertyName("risk_details")]
        public RequestedSessionRiskDetailsOptions RiskDetails { get; set; }

        /// <summary>
        /// Set to true when using Stripe.js, iOS, or Android client-side SDKs to handle next
        /// actions.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        [STJS.JsonPropertyName("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}
