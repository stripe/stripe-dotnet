// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenPaymentMethodDetailsStripeBalance : StripeEntity<GrantedTokenPaymentMethodDetailsStripeBalance>
    {
        /// <summary>
        /// The connected account ID whose Stripe balance to use as the source of payment.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }
    }
}
