// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAmazonPay : StripeEntity<ChargePaymentMethodDetailsAmazonPay>
    {
        [JsonProperty("funding")]
        public ChargePaymentMethodDetailsAmazonPayFunding Funding { get; set; }
    }
}
