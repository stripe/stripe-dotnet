// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// The default contact email address for the Account. Required when configuring the account
        /// as a merchant or recipient.
        /// </summary>
        [JsonProperty("contact_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("contact_email")]
#endif
        public string ContactEmail { get; set; }

        /// <summary>
        /// The default contact phone for the Account.
        /// </summary>
        [JsonProperty("contact_phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("contact_phone")]
#endif
        public string ContactPhone { get; set; }

        /// <summary>
        /// A descriptive name for the Account. This name will be surfaced in the Stripe Dashboard
        /// and on any invoices sent to the Account.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Information about the company, individual, and business represented by the Account.
        /// </summary>
        [JsonProperty("identity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identity")]
#endif
        public AccountTokenCreateIdentityOptions Identity { get; set; }
    }
}
