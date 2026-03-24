// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// The default contact email address for the Account. Required when configuring the account
        /// as a merchant or recipient.
        /// </summary>
        [JsonProperty("contact_email")]
        [STJS.JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// The default contact phone for the Account.
        /// </summary>
        [JsonProperty("contact_phone")]
        [STJS.JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// A descriptive name for the Account. This name will be surfaced in the Stripe Dashboard
        /// and on any invoices sent to the Account.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Information about the company, individual, and business represented by the Account.
        /// </summary>
        [JsonProperty("identity")]
        [STJS.JsonPropertyName("identity")]
        public AccountTokenCreateIdentityOptions Identity { get; set; }
    }
}
