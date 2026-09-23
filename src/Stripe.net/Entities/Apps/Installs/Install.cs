// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An app install represents a Stripe App that is installed on an account. It reports the
    /// permissions, content security policy entries, and endpoints that the installing account
    /// has authorized, along with any that the app's latest version requests but the account
    /// has not authorized yet. Use the Install API to install, reauthorize, and uninstall apps,
    /// and to check the state of existing installs.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Install : StripeEntity<Install>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The ID of the account that the app install belongs to.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The ID of the app installed.
        /// </summary>
        [JsonProperty("app")]
        [STJS.JsonPropertyName("app")]
        public string App { get; set; }

        /// <summary>
        /// Whether the installer must authorize pending permissions, content security policy
        /// entries, or endpoints. For private apps, <c>approval_required</c> stays <c>false</c>.
        /// Install a new version from the Dashboard to grant its permissions.
        /// </summary>
        [JsonProperty("approval_required")]
        [STJS.JsonPropertyName("approval_required")]
        public bool ApprovalRequired { get; set; }

        /// <summary>
        /// The authorization code for an oauth app install.
        /// </summary>
        [JsonProperty("auth_code")]
        [STJS.JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        [JsonProperty("authorized_content_security_policy")]
        [STJS.JsonPropertyName("authorized_content_security_policy")]
        public InstallAuthorizedContentSecurityPolicy AuthorizedContentSecurityPolicy { get; set; }

        /// <summary>
        /// The endpoint URLs authorized by the installer.
        /// </summary>
        [JsonProperty("authorized_endpoints")]
        [STJS.JsonPropertyName("authorized_endpoints")]
        public List<string> AuthorizedEndpoints { get; set; }

        /// <summary>
        /// The permissions authorized by the installer.
        /// </summary>
        [JsonProperty("authorized_permissions")]
        [STJS.JsonPropertyName("authorized_permissions")]
        public List<string> AuthorizedPermissions { get; set; }

        /// <summary>
        /// The distribution channel associated with the app install.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// The content security policy entries authorized by the installer.
        /// </summary>
        [JsonProperty("content_security_policy_granted")]
        [STJS.JsonPropertyName("content_security_policy_granted")]
        public InstallContentSecurityPolicyGranted ContentSecurityPolicyGranted { get; set; }

        [JsonProperty("content_security_policy_pending")]
        [STJS.JsonPropertyName("content_security_policy_pending")]
        public InstallContentSecurityPolicyPending ContentSecurityPolicyPending { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the embedding platform that created the install, if applicable.
        /// </summary>
        [JsonProperty("created_by")]
        [STJS.JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The endpoint URLs authorized by the installer.
        /// </summary>
        [JsonProperty("endpoints_granted")]
        [STJS.JsonPropertyName("endpoints_granted")]
        public List<string> EndpointsGranted { get; set; }

        /// <summary>
        /// The endpoint URLs requested by the latest app version that the installer has not
        /// authorized.
        /// </summary>
        [JsonProperty("endpoints_pending")]
        [STJS.JsonPropertyName("endpoints_pending")]
        public List<string> EndpointsPending { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The permissions authorized by the installer.
        /// </summary>
        [JsonProperty("permissions_granted")]
        [STJS.JsonPropertyName("permissions_granted")]
        public List<string> PermissionsGranted { get; set; }

        /// <summary>
        /// The permissions requested by the latest app version that the installer has not
        /// authorized.
        /// </summary>
        [JsonProperty("permissions_pending")]
        [STJS.JsonPropertyName("permissions_pending")]
        public List<string> PermissionsPending { get; set; }

        /// <summary>
        /// The status of the app install.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The status of the app install.
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
