// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodDomainPaypalStatusDetails : StripeEntity<PaymentMethodDomainPaypalStatusDetails>
    {
        /// <summary>
        /// The error message associated with the status of the payment method on the domain.
        /// </summary>
        [JsonProperty("error_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_message")]
#endif

        public string ErrorMessage { get; set; }
    }
}
