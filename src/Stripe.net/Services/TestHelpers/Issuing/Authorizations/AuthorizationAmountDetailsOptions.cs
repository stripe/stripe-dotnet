// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationAmountDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The ATM withdrawal fee.
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
