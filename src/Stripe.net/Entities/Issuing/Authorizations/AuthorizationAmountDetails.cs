// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationAmountDetails : StripeEntity<AuthorizationAmountDetails>
    {
        /// <summary>
        /// The fee charged by the ATM for the cash withdrawal.
        /// </summary>
        [JsonProperty("atm_fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("atm_fee")]
#endif
        public long? AtmFee { get; set; }

        /// <summary>
        /// The amount of cash requested by the cardholder.
        /// </summary>
        [JsonProperty("cashback_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashback_amount")]
#endif
        public long? CashbackAmount { get; set; }
    }
}
