// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionConfirmOptions : BaseOptions
    {
        /// <summary>
        /// Affiliate attribution data associated with this requested session.
        /// </summary>
        [JsonProperty("affiliate_attribution")]
        [STJS.JsonPropertyName("affiliate_attribution")]
        public RequestedSessionAffiliateAttributionOptions AffiliateAttribution { get; set; }

        /// <summary>
        /// The PaymentMethod to use with the requested session.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Risk details/signals associated with the requested session.
        /// </summary>
        [JsonProperty("risk_details")]
        [STJS.JsonPropertyName("risk_details")]
        public RequestedSessionRiskDetailsOptions RiskDetails { get; set; }
    }
}
