// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAmazonPayFunding : StripeEntity<ChargePaymentMethodDetailsAmazonPayFunding>
    {
        [JsonProperty("card")]
        public ChargePaymentMethodDetailsAmazonPayFundingCard Card { get; set; }

        /// <summary>
        /// funding type of the underlying payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
