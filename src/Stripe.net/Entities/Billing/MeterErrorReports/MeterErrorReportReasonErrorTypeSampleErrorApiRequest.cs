// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterErrorReportReasonErrorTypeSampleErrorApiRequest : StripeEntity<MeterErrorReportReasonErrorTypeSampleErrorApiRequest>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// idempotency_key of the request.
        /// </summary>
        [JsonProperty("idempotency_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("idempotency_key")]
#endif
        public string IdempotencyKey { get; set; }
    }
}
