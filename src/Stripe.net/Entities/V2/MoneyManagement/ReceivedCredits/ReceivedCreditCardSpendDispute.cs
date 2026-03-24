// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditCardSpendDispute : StripeEntity<ReceivedCreditCardSpendDispute>
    {
        /// <summary>
        /// The reference to the v1 issuing dispute ID.
        /// </summary>
        [JsonProperty("issuing_dispute_v1")]
        [STJS.JsonPropertyName("issuing_dispute_v1")]
        public string IssuingDisputeV1 { get; set; }
    }
}
