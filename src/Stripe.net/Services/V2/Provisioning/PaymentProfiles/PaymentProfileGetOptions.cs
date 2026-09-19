// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentProfileGetOptions : BaseOptions
    {
        /// <summary>
        /// Whether the billing operation should use Stripe live-mode objects. When omitted, this
        /// resolves from the authenticated request context.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool? Livemode { get; set; }
    }
}
