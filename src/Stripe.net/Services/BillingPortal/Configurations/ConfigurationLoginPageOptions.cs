// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationLoginPageOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to generate a shareable URL <a
        /// href="https://stripe.com/docs/api/customer_portal/configuration#portal_configuration_object-login_page-url"><c>login_page.url</c></a>
        /// that will take your customers to a hosted login page for the customer portal.
        ///
        /// Set to <c>false</c> to deactivate the <c>login_page.url</c>.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }
    }
}
