// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditStatusDetails : StripeEntity<ReceivedCreditStatusDetails>
    {
        /// <summary>
        /// Hash that provides additional information regarding the reason behind a <c>failed</c>
        /// ReceivedCredit status. It is only present when the ReceivedCredit status is
        /// <c>failed</c>.
        /// </summary>
        [JsonProperty("failed")]
        [STJS.JsonPropertyName("failed")]
        public ReceivedCreditStatusDetailsFailed Failed { get; set; }

        /// <summary>
        /// Hash that provides additional information regarding the reason behind a <c>returned</c>
        /// ReceivedCredit status. It is only present when the ReceivedCredit status is
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("returned")]
        [STJS.JsonPropertyName("returned")]
        public ReceivedCreditStatusDetailsReturned Returned { get; set; }
    }
}
