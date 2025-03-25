// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditCardSpendDispute : StripeEntity<ReceivedCreditCardSpendDispute>
    {
        /// <summary>
        /// The reference to the v1 issuing dispute ID.
        /// </summary>
        [JsonProperty("issuing_dispute_v1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_dispute_v1")]
#endif
        public string IssuingDisputeV1 { get; set; }
    }
}
