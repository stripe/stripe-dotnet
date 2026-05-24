// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkPaymentMethodOptionsCard : StripeEntity<PaymentLinkPaymentMethodOptionsCard>
    {
        /// <summary>
        /// Restrictions to apply to the card payment method. For example, you can block specific
        /// card brands.
        /// </summary>
        [JsonProperty("restrictions")]
        [STJS.JsonPropertyName("restrictions")]
        public PaymentLinkPaymentMethodOptionsCardRestrictions Restrictions { get; set; }
    }
}
