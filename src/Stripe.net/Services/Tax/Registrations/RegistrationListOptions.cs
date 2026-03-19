// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RegistrationListOptions : ListOptions
    {
        /// <summary>
        /// The status of the Tax Registration.
        /// One of: <c>active</c>, <c>all</c>, <c>expired</c>, or <c>scheduled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
