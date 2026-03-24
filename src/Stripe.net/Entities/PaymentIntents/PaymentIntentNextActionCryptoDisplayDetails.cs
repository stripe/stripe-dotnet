// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionCryptoDisplayDetails : StripeEntity<PaymentIntentNextActionCryptoDisplayDetails>
    {
        [JsonProperty("deposit_addresses")]
        [STJS.JsonPropertyName("deposit_addresses")]
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddresses DepositAddresses { get; set; }
    }
}
