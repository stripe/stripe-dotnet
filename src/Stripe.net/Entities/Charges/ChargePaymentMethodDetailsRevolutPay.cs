// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsRevolutPay : StripeEntity<ChargePaymentMethodDetailsRevolutPay>
    {
        [JsonProperty("funding")]
        public ChargePaymentMethodDetailsRevolutPayFunding Funding { get; set; }
    }
}
