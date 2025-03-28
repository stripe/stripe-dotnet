// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditStatusDetails : StripeEntity<ReceivedCreditStatusDetails>
    {
        /// <summary>
        /// Hash that provides additional information regarding the reason behind a <c>failed</c>
        /// ReceivedCredit status. It is only present when the ReceivedCredit status is
        /// <c>failed</c>.
        /// </summary>
        [JsonProperty("failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed")]
#endif
        public ReceivedCreditStatusDetailsFailed Failed { get; set; }

        /// <summary>
        /// Hash that provides additional information regarding the reason behind a <c>returned</c>
        /// ReceivedCredit status. It is only present when the ReceivedCredit status is
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("returned")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("returned")]
#endif
        public ReceivedCreditStatusDetailsReturned Returned { get; set; }
    }
}
