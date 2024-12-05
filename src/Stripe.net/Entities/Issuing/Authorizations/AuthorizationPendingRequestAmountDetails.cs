// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationPendingRequestAmountDetails : StripeEntity<AuthorizationPendingRequestAmountDetails>
    {
        /// <summary>
        /// The fee charged by the ATM for the cash withdrawal.
        /// </summary>
        [JsonProperty("atm_fee")]
        public long? AtmFee { get; set; }

        /// <summary>
        /// The amount of cash requested by the cardholder.
        /// </summary>
        [JsonProperty("cashback_amount")]
        public long? CashbackAmount { get; set; }
    }
}
