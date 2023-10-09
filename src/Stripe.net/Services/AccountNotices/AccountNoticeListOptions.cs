// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountNoticeListOptions : ListOptions
    {
        /// <summary>
        /// Set to false to only return unsent AccountNotices.
        /// </summary>
        [JsonProperty("sent")]
        public bool? Sent { get; set; }
    }
}
