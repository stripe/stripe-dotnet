// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A customer's payment method and its usage limits.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentProfile : StripeEntity<PaymentProfile>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Last 4 digits of the card on the payment method.
        /// </summary>
        [JsonProperty("card_last4")]
        [STJS.JsonPropertyName("card_last4")]
        public string CardLast4 { get; set; }

        /// <summary>
        /// Whether the payment method is in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Owner of the payment method.
        /// </summary>
        [JsonProperty("payment_method_owner")]
        [STJS.JsonPropertyName("payment_method_owner")]
        public string PaymentMethodOwner { get; set; }

        /// <summary>
        /// Providers the payment method is shared with, and their usage limits.
        /// </summary>
        [JsonProperty("providers")]
        [STJS.JsonPropertyName("providers")]
        public List<PaymentProfileProvider> Providers { get; set; }

        /// <summary>
        /// Deprecated: use providers instead.
        /// </summary>
        [JsonProperty("shared_with_providers")]
        [STJS.JsonPropertyName("shared_with_providers")]
        public List<string> SharedWithProviders { get; set; }

        /// <summary>
        /// Usage limit applied to the payment method.
        /// </summary>
        [JsonProperty("usage_limits")]
        [STJS.JsonPropertyName("usage_limits")]
        public PaymentProfileUsageLimits UsageLimits { get; set; }
    }
}
