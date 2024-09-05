// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterErrorReportReasonErrorTypeSampleErrorApiRequest : StripeEntity<MeterErrorReportReasonErrorTypeSampleErrorApiRequest>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// idempotency_key of the request.
        /// </summary>
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }
}
