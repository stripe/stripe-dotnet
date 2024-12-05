// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Select Issuing disputes with the given status.
        /// One of: <c>expired</c>, <c>lost</c>, <c>submitted</c>, <c>unsubmitted</c>, or
        /// <c>won</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Select the Issuing dispute for the given transaction.
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }
}
