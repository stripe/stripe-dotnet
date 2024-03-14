// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterListOptions : ListOptions
    {
        /// <summary>
        /// Filter results to only include meters with the given status.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
