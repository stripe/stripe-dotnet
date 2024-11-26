// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodDomainPaypal : StripeEntity<PaymentMethodDomainPaypal>
    {
        /// <summary>
        /// The status of the payment method on the domain.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Contains additional details about the status of a payment method for a specific payment
        /// method domain.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public PaymentMethodDomainPaypalStatusDetails StatusDetails { get; set; }
    }
}
