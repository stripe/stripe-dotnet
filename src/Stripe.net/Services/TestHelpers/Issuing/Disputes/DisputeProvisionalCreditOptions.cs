// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeProvisionalCreditOptions : BaseOptions
    {
        /// <summary>
        /// Override the deadline by which the platform must grant a provisional credit to the
        /// consumer.
        /// </summary>
        [JsonProperty("grant_deadline")]
        [STJS.JsonPropertyName("grant_deadline")]
        public long? GrantDeadline { get; set; }

        /// <summary>
        /// Override the earliest time after which the platform may revoke the provisional credit.
        /// </summary>
        [JsonProperty("revocable_after")]
        [STJS.JsonPropertyName("revocable_after")]
        public long? RevocableAfter { get; set; }
    }
}
