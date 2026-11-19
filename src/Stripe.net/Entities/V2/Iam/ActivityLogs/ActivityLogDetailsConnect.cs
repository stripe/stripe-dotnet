// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsConnect : StripeEntity<ActivityLogDetailsConnect>
    {
        /// <summary>
        /// The Connect application.
        /// </summary>
        [JsonProperty("application")]
        [STJS.JsonPropertyName("application")]
        public ActivityLogDetailsConnectApplication Application { get; set; }

        /// <summary>
        /// Express Dashboard branding settings after the change. Set for the
        /// connect_express_branding_updated action.
        /// </summary>
        [JsonProperty("new_express_branding_settings")]
        [STJS.JsonPropertyName("new_express_branding_settings")]
        public ActivityLogDetailsConnectNewExpressBrandingSettings NewExpressBrandingSettings { get; set; }

        /// <summary>
        /// Connect settings after the change. Set for the connect_settings_updated action.
        /// </summary>
        [JsonProperty("new_settings")]
        [STJS.JsonPropertyName("new_settings")]
        public ActivityLogDetailsConnectNewSettings NewSettings { get; set; }

        /// <summary>
        /// Express Dashboard branding settings before the change. Set for the
        /// connect_express_branding_updated action.
        /// </summary>
        [JsonProperty("old_express_branding_settings")]
        [STJS.JsonPropertyName("old_express_branding_settings")]
        public ActivityLogDetailsConnectOldExpressBrandingSettings OldExpressBrandingSettings { get; set; }

        /// <summary>
        /// Connect settings before the change. Set for the connect_settings_updated action.
        /// </summary>
        [JsonProperty("old_settings")]
        [STJS.JsonPropertyName("old_settings")]
        public ActivityLogDetailsConnectOldSettings OldSettings { get; set; }

        /// <summary>
        /// The site link route. Set for the connect_site_link_updated action.
        /// One of: <c>account_management</c>, <c>balances</c>, <c>documents</c>,
        /// <c>financial_accounts</c>, <c>issuing_card_transactions</c>, <c>notification_banner</c>,
        /// <c>payments</c>, or <c>payouts</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("site_link_route")]
        [STJS.JsonPropertyName("site_link_route")]
        public string SiteLinkRoute { get; set; }
    }
}
