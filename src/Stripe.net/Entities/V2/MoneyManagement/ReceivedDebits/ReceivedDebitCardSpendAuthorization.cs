// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitCardSpendAuthorization : StripeEntity<ReceivedDebitCardSpendAuthorization>
    {
        /// <summary>
        /// Amount associated with this issuing authorization.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public ReceivedDebitCardSpendAuthorizationAmount Amount { get; set; }

        /// <summary>
        /// The reference to the v1 issuing authorization ID.
        /// </summary>
        [JsonProperty("issuing_authorization_v1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_authorization_v1")]
#endif
        public string IssuingAuthorizationV1 { get; set; }
    }
}
