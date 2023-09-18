// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkListOptions : ListOptions
    {
        /// <summary>
        /// Only return payment links that are active or inactive (e.g., pass <c>false</c> to list
        /// all inactive payment links).
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }
    }
}
