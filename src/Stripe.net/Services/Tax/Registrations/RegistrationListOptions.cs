// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationListOptions : ListOptions
    {
        /// <summary>
        /// The status of the Tax Registration.
        /// One of: <c>active</c>, <c>all</c>, <c>expired</c>, or <c>scheduled</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }
    }
}
