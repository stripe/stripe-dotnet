// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountNoticeListOptions : ListOptions
    {
        /// <summary>
        /// Set to false to only return unsent AccountNotices.
        /// </summary>
        [JsonProperty("sent")]
        [STJS.JsonPropertyName("sent")]
        public bool? Sent { get; set; }
    }
}
