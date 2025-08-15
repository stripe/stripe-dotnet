// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateOptions : BaseOptions
    {
        /// <summary>
        /// Actions to be performed by this BillingIntent.
        /// </summary>
        [JsonProperty("actions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("actions")]
#endif
        public List<IntentCreateActionOptions> Actions { get; set; }

        /// <summary>
        /// ID of an existing Cadence to use.
        /// </summary>
        [JsonProperty("cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cadence")]
#endif
        public string Cadence { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// When the BillingIntent will take effect.
        /// One of: <c>current_billing_period_start</c>, <c>on_commit</c>, or <c>on_reserve</c>.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif
        public string EffectiveAt { get; set; }
    }
}
