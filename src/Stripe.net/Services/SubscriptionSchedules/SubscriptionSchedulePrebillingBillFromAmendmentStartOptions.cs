// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePrebillingBillFromAmendmentStartOptions : INestedOptions
    {
        /// <summary>
        /// The position of the amendment in the <c>amendments</c> array with which prebilling
        /// should begin. Indexes start from 0 and must be less than the total number of supplied
        /// amendments.
        /// </summary>
        [JsonProperty("index")]
        [STJS.JsonPropertyName("index")]
        public long? Index { get; set; }
    }
}
