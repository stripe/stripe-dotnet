// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodDomainApplePay : StripeEntity<PaymentMethodDomainApplePay>
    {
        /// <summary>
        /// The status of the payment method on the domain.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Contains additional details about the status of a payment method for a specific payment
        /// method domain.
        /// </summary>
        [JsonProperty("status_details")]
        public PaymentMethodDomainApplePayStatusDetails StatusDetails { get; set; }
    }
}
