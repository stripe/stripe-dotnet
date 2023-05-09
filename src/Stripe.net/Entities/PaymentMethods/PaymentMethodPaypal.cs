// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodPaypal : StripeEntity<PaymentMethodPaypal>
    {
        /// <summary>
        /// PayPal account PayerID. This identifier uniquely identifies the PayPal customer.
        /// </summary>
        [JsonProperty("payer_id")]
        public string PayerId { get; set; }
    }
}
