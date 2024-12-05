// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodDomainApplePayStatusDetails : StripeEntity<PaymentMethodDomainApplePayStatusDetails>
    {
        /// <summary>
        /// The error message associated with the status of the payment method on the domain.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}
