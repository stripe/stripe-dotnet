// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentItem : StripeEntity<OffSessionPaymentItem>
    {
        /// <summary>
        /// The persisted one-time prices in this item group.
        /// </summary>
        [JsonProperty("one_time_price")]
        [STJS.JsonPropertyName("one_time_price")]
        public OffSessionPaymentItemOneTimePrice OneTimePrice { get; set; }

        /// <summary>
        /// The type of item. Currently, only <c>one_time_price</c> is supported.
        /// One of: <c>one_time_price</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
