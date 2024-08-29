// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterErrorReportRelatedObject : StripeEntity<MeterErrorReportRelatedObject>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of meter error related object. Should be 'meter'.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The url of the meter object.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
