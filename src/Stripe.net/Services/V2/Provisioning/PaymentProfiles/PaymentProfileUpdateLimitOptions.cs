// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentProfileUpdateLimitOptions : BaseOptions
    {
        /// <summary>
        /// Whether the billing operation should use Stripe live-mode objects. When omitted, this
        /// resolves from the authenticated request context.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool? Livemode { get; set; }

        /// <summary>
        /// Provider to update the usage limit for.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// New usage limit to apply.
        /// </summary>
        [JsonProperty("usage_limits")]
        [STJS.JsonPropertyName("usage_limits")]
        public PaymentProfileUpdateLimitUsageLimitsOptions UsageLimits { get; set; }
    }
}
