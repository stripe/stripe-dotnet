// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionCryptoDisplayDetails : StripeEntity<PaymentIntentNextActionCryptoDisplayDetails>
    {
        [JsonProperty("deposit_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deposit_addresses")]
#endif
        public PaymentIntentNextActionCryptoDisplayDetailsDepositAddresses DepositAddresses { get; set; }
    }
}
