// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAfterpayClearpay : StripeEntity<ChargePaymentMethodDetailsAfterpayClearpay>
    {
        /// <summary>
        /// Order identifier shown to the customer in Afterpay’s online portal.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
