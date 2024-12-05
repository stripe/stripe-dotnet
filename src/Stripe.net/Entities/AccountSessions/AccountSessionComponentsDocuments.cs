// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsDocuments : StripeEntity<AccountSessionComponentsDocuments>
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("features")]
        public AccountSessionComponentsDocumentsFeatures Features { get; set; }
    }
}
