// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RedactionJobListOptions : ListOptions
    {
        /// <summary>
        /// If provided, only RedactionJob objects with the given status will be returned.
        /// One of: <c>canceled</c>, <c>canceling</c>, <c>created</c>, <c>failed</c>, <c>ready</c>,
        /// <c>redacting</c>, <c>succeeded</c>, or <c>validating</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
