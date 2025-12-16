// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.SharedPayment
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GrantedTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Customer that the SharedPaymentGrantedToken belongs to. Should match the Customer
        /// that the PaymentMethod is attached to if any.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The PaymentMethod that is going to be shared by the SharedPaymentGrantedToken.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to the SharedPaymentGrantedToken.
        /// </summary>
        [JsonProperty("shared_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shared_metadata")]
#endif
        public Dictionary<string, string> SharedMetadata { get; set; }

        /// <summary>
        /// Limits on how this SharedPaymentGrantedToken can be used.
        /// </summary>
        [JsonProperty("usage_limits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_limits")]
#endif
        public GrantedTokenUsageLimitsOptions UsageLimits { get; set; }
    }
}
