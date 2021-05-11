// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsAfterpayClearpay : StripeEntity<PaymentIntentPaymentMethodOptionsAfterpayClearpay>
    {
        /// <summary>
        /// Order identifier shown to the merchant in Afterpay’s online portal. We recommend using a
        /// value that helps you answer any questions a customer might have about the payment. The
        /// identifier is limited to 128 characters and may contain only letters, digits,
        /// underscores, backslashes and dashes.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
