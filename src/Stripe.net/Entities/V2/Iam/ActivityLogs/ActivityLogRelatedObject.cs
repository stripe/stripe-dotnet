// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogRelatedObject : StripeEntity<ActivityLogRelatedObject>, IHasId
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Type of the object.
        /// One of: <c>balance_transfer</c>, <c>bank_account</c>, <c>blockchain_address</c>,
        /// <c>card</c>, <c>issuing.card</c>, <c>issuing.cardholder</c>, or <c>issuing.dispute</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
