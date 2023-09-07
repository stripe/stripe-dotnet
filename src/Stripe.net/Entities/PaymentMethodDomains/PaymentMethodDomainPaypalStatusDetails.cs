// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodDomainPaypalStatusDetails : StripeEntity<PaymentMethodDomainPaypalStatusDetails>
    {
        /// <summary>
        /// The error message associated with the status of the payment method on the domain.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}
