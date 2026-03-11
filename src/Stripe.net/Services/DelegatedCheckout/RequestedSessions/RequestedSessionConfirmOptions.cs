// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionConfirmOptions : BaseOptions
    {
        /// <summary>
        /// Affiliate attribution data associated with this requested session.
        /// </summary>
        [JsonProperty("affiliate_attribution")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate_attribution")]
#endif
        public RequestedSessionAffiliateAttributionOptions AffiliateAttribution { get; set; }

        /// <summary>
        /// The PaymentMethod to use with the requested session.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The payment method data for this requested session.
        /// </summary>
        [JsonProperty("payment_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_data")]
#endif
        public RequestedSessionPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Risk details/signals associated with the requested session.
        /// </summary>
        [JsonProperty("risk_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("risk_details")]
#endif
        public RequestedSessionRiskDetailsOptions RiskDetails { get; set; }
    }
}
