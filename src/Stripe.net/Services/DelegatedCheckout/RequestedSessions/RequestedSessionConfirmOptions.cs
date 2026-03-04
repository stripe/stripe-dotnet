// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionConfirmOptions : BaseOptions
    {
        /// <summary>
        /// Affiliate attribution data associated with this requested session.
        /// </summary>
        [JsonProperty("affiliate_attributions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate_attributions")]
#endif
        public List<RequestedSessionAffiliateAttributionOptions> AffiliateAttributions { get; set; }

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
