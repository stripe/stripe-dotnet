// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCryptoDepositOptions : StripeEntity<PaymentIntentPaymentMethodOptionsCryptoDepositOptions>
    {
        /// <summary>
        /// The blockchain networks to support for deposits. Learn more about <a
        /// href="https://docs.stripe.com/payments/deposit-mode-stablecoin-payments#token-and-network-support">supported
        /// networks and tokens</a>.
        /// One of: <c>base</c>, <c>solana</c>, or <c>tempo</c>.
        /// </summary>
        [JsonProperty("networks")]
        [STJS.JsonPropertyName("networks")]
        public List<string> Networks { get; set; }
    }
}
