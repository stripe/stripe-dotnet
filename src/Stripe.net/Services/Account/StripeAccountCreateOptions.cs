using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountCreateOptions : StripeAccountSharedOptions
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// One of <see cref="StripeAccountType"/>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from_recipient")]
        public string FromRecipient { get; set; }
    }
}
