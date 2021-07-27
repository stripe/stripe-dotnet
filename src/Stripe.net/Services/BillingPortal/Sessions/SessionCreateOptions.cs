// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of an existing <a
        /// href="https://stripe.com/docs/api/customer_portal/configuration">configuration</a> to
        /// use for this session, describing its functionality and features. If not specified, the
        /// session uses the default configuration.
        /// </summary>
        [JsonProperty("configuration")]
        public string Configuration { get; set; }

        /// <summary>
        /// The ID of an existing customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The <c>on_behalf_of</c> account to use for this session. When specified, only
        /// subscriptions and invoices with this <c>on_behalf_of</c> account appear in the portal.
        /// For more information, see the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#on-behalf-of">docs</a>. Use the
        /// <a
        /// href="https://stripe.com/docs/api/accounts/object#account_object-settings-branding">Accounts
        /// API</a> to modify the <c>on_behalf_of</c> account's branding settings, which the portal
        /// displays.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The default URL to redirect customers to when they click on the portal's link to return
        /// to your website.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
