// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCardWalletLink : StripeEntity<ChargePaymentMethodDetailsCardWalletLink>
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/payments/link/link-payment-methods">funding source
        /// group code</a> applied to this Link payment at confirmation time.
        /// </summary>
        [JsonProperty("funding_source_group")]
        [STJS.JsonPropertyName("funding_source_group")]
        public string FundingSourceGroup { get; set; }
    }
}
