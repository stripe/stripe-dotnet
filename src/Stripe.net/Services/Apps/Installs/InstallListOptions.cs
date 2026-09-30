// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InstallListOptions : ListOptions
    {
        /// <summary>
        /// Only return installs made by this account. Only useful to app developers and embedding
        /// platforms, whose lists span the accounts that installed their app.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Only return installs for the app specified by this app ID.
        /// </summary>
        [JsonProperty("app")]
        [STJS.JsonPropertyName("app")]
        public string App { get; set; }

        /// <summary>
        /// Only return installs whose installer must authorize pending permissions, content
        /// security policy entries, or endpoints.
        /// </summary>
        [JsonProperty("approval_required")]
        [STJS.JsonPropertyName("approval_required")]
        public bool? ApprovalRequired { get; set; }

        /// <summary>
        /// Only return installs in the distribution channel specified by this channel name.
        /// One of: <c>private_live</c>, <c>private_test</c>, <c>public</c>, or <c>testing</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// Only return app installs that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return installs created by the embedding platform specified by this account ID.
        /// </summary>
        [JsonProperty("created_by")]
        [STJS.JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Only return installs with the given status.
        /// One of: <c>install_failed</c>, <c>installed</c>, <c>installing</c>,
        /// <c>uninstall_failed</c>, or <c>uninstalling</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
