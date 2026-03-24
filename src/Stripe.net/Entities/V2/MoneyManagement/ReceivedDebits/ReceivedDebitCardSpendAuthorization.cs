// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitCardSpendAuthorization : StripeEntity<ReceivedDebitCardSpendAuthorization>
    {
        /// <summary>
        /// Amount associated with this issuing authorization.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The reference to the v1 issuing authorization ID.
        /// </summary>
        [JsonProperty("issuing_authorization_v1")]
        [STJS.JsonPropertyName("issuing_authorization_v1")]
        public string IssuingAuthorizationV1 { get; set; }
    }
}
