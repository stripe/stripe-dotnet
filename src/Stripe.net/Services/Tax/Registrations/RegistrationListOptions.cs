// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationListOptions : ListOptions
    {
        /// <summary>
        /// The status of the Tax Registration.
        /// One of: <c>active</c>, <c>all</c>, <c>expired</c>, or <c>scheduled</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
