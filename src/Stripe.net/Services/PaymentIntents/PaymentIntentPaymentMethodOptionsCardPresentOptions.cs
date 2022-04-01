// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardPresentOptions : INestedOptions
    {
        /// <summary>
        /// Request ability to capture this payment beyond the standard <a
        /// href="https://stripe.com/docs/terminal/features/extended-authorizations#authorization-validity">authorization
        /// validity window</a>.
        /// </summary>
        [JsonProperty("request_extended_authorization")]
        public bool? RequestExtendedAuthorization { get; set; }
    }
}
