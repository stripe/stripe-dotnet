// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ClaimableSandboxOwnerDetails : StripeEntity<ClaimableSandboxOwnerDetails>
    {
        /// <summary>
        /// The ID of the live mode Stripe account that owns the sandbox. This field is only set
        /// when <c>owner_details.app_install_status</c> is <c>installed</c>.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Indicates whether the platform app is installed on the sandbox’s live mode owner
        /// account.
        /// One of: <c>installed</c>, <c>pending_install</c>, or <c>pending_onboarding</c>.
        /// </summary>
        [JsonProperty("app_install_status")]
        [STJS.JsonPropertyName("app_install_status")]
        public string AppInstallStatus { get; set; }
    }
}
