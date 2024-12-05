// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsKonbini : StripeEntity<ChargePaymentMethodDetailsKonbini>
    {
        /// <summary>
        /// If the payment succeeded, this contains the details of the convenience store where the
        /// payment was completed.
        /// </summary>
        [JsonProperty("store")]
        public ChargePaymentMethodDetailsKonbiniStore Store { get; set; }
    }
}
