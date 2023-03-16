// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsLink : StripeEntity<ChargePaymentMethodDetailsLink>
    {
        /// <summary>
        /// Two-letter ISO code representing the funding source country beneath the Link payment.
        /// You could use this attribute to get a sense of international fees.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
