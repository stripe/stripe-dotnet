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
        /// One of: <c>canceled</c>, <c>canceling</c>, <c>created</c>, <c>failed</c>, <c>ready</c>,
        /// <c>redacting</c>, <c>succeeded</c>, or <c>validating</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
