// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationAmountDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The ATM withdrawal fee.
        /// </summary>
        [JsonProperty("atm_fee")]
        [STJS.JsonPropertyName("atm_fee")]
        public long? AtmFee { get; set; }

        /// <summary>
        /// The amount of cash requested by the cardholder.
        /// </summary>
        [JsonProperty("cashback_amount")]
        [STJS.JsonPropertyName("cashback_amount")]
        public long? CashbackAmount { get; set; }
    }
}
